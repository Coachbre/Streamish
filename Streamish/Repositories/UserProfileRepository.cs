//using System.Collections.Generic;
//using System.Linq;
//using Microsoft.Extensions.Configuration;
//using Streamish.Models;
//using Streamish.Utils;

//namespace Streamish.Repositories
//{
//    public class UserProfileRepository : BaseRepository, IUserProfileRepository
//    {
//        public UserProfileRepository(IConfiguration configuration) : base(configuration) { }

//        public List<UserProfile> GetAll()
//        {
//            using (var conn = Connection)
//            {
//                conn.Open();
//                using (var cmd = conn.CreateCommand())
//                {
//                    cmd.CommandText = @"
//                        SELECT UserProfile.Id,
//		                    UserProfile.Name,
//		                    UserProfile.Email,
//		                    UserProfile.ImageUrl,
//		                    UserProfile.DateCreated
//                        FROM UserProfile;                      
//                        ";

//                    var reader = cmd.ExecuteReader();

//                    var userProfiles = new List<UserProfile>();
//                    while (reader.Read())
//                    {
//                        userProfiles.Add(new UserProfile()
//                        {
//                            Id = DbUtils.GetInt(reader, "Id"),
//                            Name = DbUtils.GetString(reader, "Name"),
//                            Email = DbUtils.GetString(reader, "Email"),
//                            DateCreated = DbUtils.GetDateTime(reader, "DateCreated"),
//                            ImageUrl = DbUtils.GetString(reader, "ImageUrl"),
//                        });
//                    }

//                    reader.Close();

//                    return userProfiles;
//                }
//            }
//        }

//        public UserProfile GetById(int id)
//        {
//            using (var conn = Connection)
//            {
//                conn.Open();
//                using (var cmd = conn.CreateCommand())
//                {
//                    cmd.CommandText = @"
//                        SELECT UserProfile.Id, UserProfile.Name, UserProfile.Email, UserProfile.DateCreated, UserProfile.ImageUrl,
//                        WHERE UserProfile.Id = @Id";

//                    DbUtils.AddParameter(cmd, "@Id", id);

//                    var reader = cmd.ExecuteReader();

//                    UserProfile userProfile = null;
//                    if (reader.Read())
//                    {
//                        userProfile = new UserProfile()
//                        {
//                            Id = DbUtils.GetInt(reader, "Id"),
//                            Name = DbUtils.GetString(reader, "Name"),
//                            Email = DbUtils.GetString(reader, "Email"),
//                            DateCreated = DbUtils.GetDateTime(reader, "DateCreated"),
//                            ImageUrl = DbUtils.GetString(reader, "ImageUrl"),
//                        };
//                    }
//                }

//            }
//        }

//        public void Add(UserProfile userProfile)
//        {
//            throw new System.NotImplementedException();
//        }

//        public void Delete(int id)
//        {
//            throw new System.NotImplementedException();
//        }

//        public void Update(UserProfile userProfile)
//        {
//            throw new System.NotImplementedException();
//        }
//    }
//}
