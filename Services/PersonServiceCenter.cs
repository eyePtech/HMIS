using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using HMIS.DTO.Registration;
using HMIS.DTO.ServiceCenterDTO;
using Microsoft.IdentityModel.Tokens;

namespace HMIS.Services
{
    public class PersonServiceCenter : IPersonServiceCenter
    {
        private readonly DataContext _Context;
        private readonly IConfiguration _configuration;

        SecurityUserMaster user = new SecurityUserMaster();
        private readonly IMapper _Mapper;
        public PersonServiceCenter(DataContext context, IMapper mapper,IConfiguration configuration)
        {
            _configuration = configuration;
            _Context = context;
            _Mapper = mapper;
        }
        public async Task<AddServiceCenterDTO> Add(AddServiceCenterDTO person)
        {
            person.code = person.code.Equals(null) || person.code.Equals(0) ? 0 : person.code;
            person.name = person.name.Equals(null) || person.name.Equals("") ? "" : person.name;
            person.department_id = person.department_id.Equals(0) || person.department_id.Equals(null) ? 0 : person.department_id;
            person.phone = person.phone.Equals(null) || person.phone.Equals(0) ? "" : person.phone;
            person.type = person.type.Equals(0) || person.type.Equals(null) ? 0 : person.type;
            person.desc = person.desc.Equals(null) || person.desc.Equals(0) ? "" : person.desc;
            person.created_date = DateTime.UtcNow;
            person.created_user_id = person.created_user_id.Equals(0) || person.created_user_id.Equals(null) ? 0 : person.created_user_id;
            person.created_location_id = person.created_location_id.Equals(0) || person.created_location_id.Equals(null) ? 0 : person.created_location_id;
            person.is_active = person.is_active.Equals(null) || person.is_active.Equals(0) ? 1 : person.is_active;
            person.is_deleted = person.is_deleted.Equals(null) || person.is_deleted.Equals(0) ? 0 : person.is_deleted;
            _Context.Service_Center_m.Add(_Mapper.Map<ServiceCenter>(person));
            _Context.SaveChanges();
            return person;
        }

        public async Task<AddSecurityUserMaster> Ragistor(AddSecurityUserMaster user)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(user.password_hash);
            user.password_hash = passwordHash;
            _Context.sec_user_m.Add(_Mapper.Map<SecurityUserMaster>(user));
            _Context.SaveChanges();
            return user;
        }

        public async Task<IEnumerable<ServiceCenter>> search(string? name, string? desc, int? code)
        {
            IQueryable<ServiceCenter> query = _Context.Service_Center_m;
            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(e => e.name.Contains(name));
            }
            if (code != null)
            {

                query = query.Where(e => e.code.Equals(code));
            }
            if (desc != null)
            {
                query = query.Where(e => e.desc.Contains(desc));
            }

            return await query.ToListAsync();
        }

        public async Task<UpdateServiceCenterDTO> Update(UpdateServiceCenterDTO person)
        {

            var s = _Context.Service_Center_m.Find(person.id);
            person.code = person.code.Equals(null) || person.code.Equals(0) ? s.code : person.code;
            person.name = person.name.Equals(null) || person.name.Equals("") ? s.name : person.name;
            person.department_id = person.department_id.Equals(0) || person.department_id.Equals(null) ? s.department_id : person.department_id;
            person.phone = person.phone.Equals(null) || person.phone.Equals(0) ? s.phone : person.phone;
            person.type = person.type.Equals(0) || person.type.Equals(null) ? s.type : person.type;
            person.desc = person.desc.Equals(null) || person.desc.Equals(0) ? s.desc : person.desc;
            person.modified_date = DateTime.UtcNow;
            person.modified_user_id = person.modified_user_id.Equals(0) || person.modified_user_id.Equals(null) ? s.modified_user_id : person.modified_user_id;
            person.modified_location_id = person.modified_location_id.Equals(0) || person.modified_location_id.Equals(null) ? s.modified_location_id : person.modified_location_id;
            person.is_active = person.is_active.Equals(null) || person.is_active.Equals(0) ? s.is_active : person.is_active;
            person.is_deleted = person.is_deleted.Equals(null) || person.is_deleted.Equals(0) ? s.is_deleted : person.is_deleted;

            _Mapper.Map(person, s);
            _Context.SaveChanges();
            Console.WriteLine(person.code);
            return person;

        }

        public async Task<string> Login(AddSecurityUserMaster user)
        {
            var userinfo = _Context.sec_user_m.SingleOrDefault(x => x.username == user.username);
            if (userinfo == null) { return "user not found"; }
            if (user == null || !BCrypt.Net.BCrypt.Verify(user.password_hash, userinfo.password_hash))
            {
                return "Username or password is incorrect";
            }
            string token = CreateToken(user);

            return token;

        }
        private string CreateToken(AddSecurityUserMaster user)
        {

            List<Claim> claims = new List<Claim> {
                new Claim(ClaimTypes.Name, user.username)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Token").Value!));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                    claims: claims,
                    expires: DateTime.Now.AddDays(1),
                    signingCredentials: creds
                );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
    }
}