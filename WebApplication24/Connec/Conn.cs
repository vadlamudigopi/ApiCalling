using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.Models;

namespace WebApplication24.Connec
{
    public class Conn
    {
        private string connstring;
        public Conn()
        {
            connstring = @"server=202.53.12.91;username=root;password= Golf2018!;database= emotions_tracker;SslMode=none";
        }
        public List<Admin> ml_admins()
        {
            List<Admin> alladmins = new List<Admin>();

            using (MySqlConnection connMySql = new MySqlConnection(connstring))
            {
                using (MySqlCommand cmdd = connMySql.CreateCommand())
                {
                    cmdd.CommandText = "Select * from ml_admins";
                    cmdd.CommandType = System.Data.CommandType.Text;
                    cmdd.Connection = connMySql;
                    connMySql.Open();
                    using (MySqlDataReader reader = cmdd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            alladmins.Add(new Admin()
                            {
                                adminId = Convert.ToInt32(reader["adminId"]),
                                userName = reader["userName"].ToString(),
                                email = reader["email"].ToString(),
                                phone = reader["phone"].ToString(),
                                schoolId = Convert.ToInt16(reader["schoolId"]),
                                classId = reader["classId"].ToString(),
                                roleId = Convert.ToInt16(reader["roleId"]),
                                isActive = Convert.ToInt16(reader["isActive"]),
                                isDeleted = Convert.ToInt16(reader["isDeleted"]),
                                createdAt = reader["createdAt"].ToString(),
                                updatedAt = reader["updatedAt"].ToString(),
                            });
                        }
                    }
                    connMySql.Close();
                }
                return alladmins;
            }
        }
        public List<Emotion> ml_emotions()

        {
            List<Emotion> allemotions = new List<Emotion>();

            using (MySqlConnection connMySql = new MySqlConnection(connstring))
            {
                using (MySqlCommand cmdd = connMySql.CreateCommand())
                {
                    cmdd.CommandText = "Select * from ml_emotions";
                    cmdd.CommandType = System.Data.CommandType.Text;
                    cmdd.Connection = connMySql;
                    connMySql.Open();
                    using (MySqlDataReader reader = cmdd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            allemotions.Add(new Emotion()
                            {
                                id = Convert.ToInt32(reader["id"]),
                                userId = Convert.ToInt32(reader["userId"]),
                                emotion = reader["emotion"].ToString(),
                                createdTime = reader["createdTime"].ToString(),
                                // updatedTime = reader["updatedTime"].ToString(),
                                gender = reader["gender"].ToString(),
                                surprise = Convert.ToDecimal(reader["surprise"]),
                                happy = Convert.ToDecimal(reader["happy"]),
                                sad = Convert.ToDecimal(reader["sad"]),
                                fear = Convert.ToDecimal(reader["fear"]),
                                neutral = Convert.ToDecimal(reader["neutral"]),
                                disgust = Convert.ToDecimal(reader["disgust"]),
                                angry = Convert.ToDecimal(reader["angry"]),
                                frame_millitime = Convert.ToInt32(reader["frame_millitime"]),
                                video_id = Convert.ToInt16(reader["video_id"]),
                            });
                        }
                    }
                    connMySql.Close();
                }
                return allemotions;
            }
        }
        public List<School> ml_schools()

        {
            List<School> allschools = new List<School>();

            using (MySqlConnection connMySql = new MySqlConnection(connstring))
            {
                using (MySqlCommand cmdd = connMySql.CreateCommand())
                {
                    cmdd.CommandText = "Select * from ml_schools";
                    cmdd.CommandType = System.Data.CommandType.Text;
                    cmdd.Connection = connMySql;
                    connMySql.Open();
                    using (MySqlDataReader reader = cmdd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            allschools.Add(new School()
                            {
                                id = Convert.ToInt32(reader["id"]),
                                school = reader["school"].ToString(),
                                school_email = reader["school_email"].ToString(),
                                school_phone = Convert.ToInt32(reader["school_phone"]),
                                school_image = reader["school_image"].ToString(),
                                school_address = reader["school_address"].ToString(),
                                school_is_active = Convert.ToInt32(reader["school_is_active"]),
                                school_is_deleted = Convert.ToInt32(reader["school_is_deleted"]),
                                createdTime = reader["createdTime"].ToString(),
                                updatedTime = reader["updatedTime"].ToString(),
                            });
                        }
                    }
                    connMySql.Close();
                }
                return allschools;
            }
        }
        public List<Section> ml_sections()
        {
            List<Section> allsections = new List<Section>();

            using (MySqlConnection connMySql = new MySqlConnection(connstring))
            {
                using (MySqlCommand cmdd = connMySql.CreateCommand())
                {
                    cmdd.CommandText = "Select * from ml_sections";
                    cmdd.CommandType = System.Data.CommandType.Text;
                    cmdd.Connection = connMySql;
                    connMySql.Open();
                    using (MySqlDataReader reader = cmdd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            allsections.Add(new Section()
                            {
                                id = Convert.ToInt32(reader["id"]),
                                section = reader["section"].ToString(),
                               class_id= Convert.ToInt32(reader["class_id"]),
                                createdTime = reader["createdTime"].ToString(),
                              // updatedTime = reader["updatedTime"].ToString(),
                            });
                        }
                    }
                    connMySql.Close();
                }
                return allsections;
            }
        }
        public List<User> ml_users()
        {
            List<User> allusers = new List<User>();

            using (MySqlConnection connMySql = new MySqlConnection(connstring))
            {
                using (MySqlCommand cmdd = connMySql.CreateCommand())
                {
                    cmdd.CommandText = "Select * from ml_users";
                    cmdd.CommandType = System.Data.CommandType.Text;
                    cmdd.Connection = connMySql;
                    connMySql.Open();
                    using (MySqlDataReader reader = cmdd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            allusers.Add(new User()
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                userID = reader["userID"].ToString(),
                                userName = reader["userName"].ToString(),
                                section_id = Convert.ToInt32(reader["section_id"]),
                                createdTime = reader["createdTime"].ToString(),
                                updatedTime = reader["updatedTime"].ToString(),
                            });
                        }
                    }
                    connMySql.Close();
                }
                return allusers;
            }
        }
        public List<Video> ml_videos()
        {
            List<Video> allvideos = new List<Video>();

            using (MySqlConnection connMySql = new MySqlConnection(connstring))
            {
                using (MySqlCommand cmdd = connMySql.CreateCommand())
                {
                    cmdd.CommandText = "Select * from ml_videos";
                    cmdd.CommandType = System.Data.CommandType.Text;
                    cmdd.Connection = connMySql;
                    connMySql.Open();
                    using (MySqlDataReader reader = cmdd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            allvideos.Add(new Video()
                            {
                                videoId = Convert.ToInt32(reader["videoId"]),
                                video = reader["video"].ToString(),
                                createdAt = reader["createdAt"].ToString(),
                                updatedAt = reader["updatedAt"].ToString(),
                                section_id = Convert.ToInt32(reader["section_id"]),
                            });
                        }
                    }
                    connMySql.Close();
                }
                return allvideos;
            }
        }
        public List<Class> ml_classes()
        {
            List<Class> allclasses = new List<Class>();

            using (MySqlConnection connMySql = new MySqlConnection(connstring))
            {
                using (MySqlCommand cmdd = connMySql.CreateCommand())
                {
                    cmdd.CommandText = "Select * from ml_classes";
                    cmdd.CommandType = System.Data.CommandType.Text;
                    cmdd.Connection = connMySql;
                    connMySql.Open();
                    using (MySqlDataReader reader = cmdd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            allclasses.Add(new Class()
                            {
                                id = Convert.ToInt32(reader["id"]),
                                school_id = Convert.ToInt32(reader["school_id"]),
                                createdTime = reader["createdTime"].ToString(),
                               // updatedTime = reader["updatedTime"].ToString(),

                            });
                        }
                    }
                    connMySql.Close();
                }
                return allclasses;
            }
        }
        public List<Rolemaster> ml_roles_master()
        {
            List<Rolemaster> allroles = new List<Rolemaster>();

            using (MySqlConnection connMySql = new MySqlConnection(connstring))
            {
                using (MySqlCommand cmdd = connMySql.CreateCommand())
                {
                    cmdd.CommandText = "Select * from ml_roles_master";
                    cmdd.CommandType = System.Data.CommandType.Text;
                    cmdd.Connection = connMySql;
                    connMySql.Open();
                    using (MySqlDataReader reader = cmdd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            allroles.Add(new Rolemaster()
                            {
                                roleId = Convert.ToInt32(reader["roleId"]),
                                roleName = reader["roleName"].ToString(),
                                roleIsActive = Convert.ToInt32(reader["roleIsActive"]),
                                roleIsDeleted = Convert.ToInt32(reader["roleIsDeleted"]),
                                roleCreatedAt = reader["roleCreatedAt"].ToString(),
                                roleUpdatedAt = reader["roleUpdatedAt"].ToString(),

                            });
                        }
                    }
                    connMySql.Close();
                }
                return allroles;
            }
        }
    }
}
