using System;
using System.Collections.Generic;
using System.IO;
using System.Configuration;

namespace TurnstileCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var imagesDir = ConfigurationManager.AppSettings["ImagesPath"];
            using (var db = new TurnstileContext())
            {
                var visitorsList = new List<Visitor>()
                {
                    new Visitor {
                        PermitId = 100,
                        FirstName = "David",
                        MiddleName = "Scot",
                        LastName = "Mustain",
                        IsValid = true,
                        RegistrationDate = DateTime.Now,
                        Picture = ConvertImageToByteArray(string.Format(imagesDir, "mustain.jpg"))
                    },
                    new Visitor {
                        PermitId = 150,
                        FirstName = "Kerry",
                        MiddleName = "Ray ",
                        LastName = "King",
                        IsValid = true,
                        RegistrationDate = DateTime.Now,
                        Picture = ConvertImageToByteArray(string.Format(imagesDir, "kerry_king.jpg"))
                    },
                    new Visitor {
                        PermitId = 110,
                        FirstName = "Philip",
                        MiddleName = "Hansen",
                        LastName = "Anselmo",
                        IsValid = false,
                        RegistrationDate = DateTime.Now,
                        Picture = ConvertImageToByteArray(string.Format(imagesDir, "anselmo.jpg"))
                    },
                    new Visitor {
                        PermitId = 10,
                        FirstName = "James",
                        MiddleName = "Alan",
                        LastName = "Hetfield",
                        IsValid = true,
                        RegistrationDate = DateTime.Now,
                        Picture = ConvertImageToByteArray(string.Format(imagesDir, "hetfield.jpg"))
                    },
                    new Visitor {
                        PermitId = 120,
                        FirstName = "Michael",
                        MiddleName = "Allan",
                        LastName = "Patton",
                        IsValid = true,
                        RegistrationDate = DateTime.Now,
                        Picture = ConvertImageToByteArray(string.Format(imagesDir, "anselmo.jpg"))
                    },
                    new Visitor {
                        PermitId = 160,
                        FirstName = "cat",
                        MiddleName = "",
                        LastName = "In Boots",
                        IsValid = false,
                        RegistrationDate = DateTime.Now,
                        Picture = ConvertImageToByteArray(string.Format(imagesDir, "cat.jpg"))
                    },
                    new Visitor {
                        PermitId = 180,
                        FirstName = "Shrek",
                        MiddleName = "",
                        LastName = "",
                        IsValid = true,
                        RegistrationDate = DateTime.Now,
                        Picture = ConvertImageToByteArray(string.Format(imagesDir, "shrek.jpg"))
                        },
                    new Visitor {
                        PermitId = 1,
                        FirstName = "Leonidas",
                        MiddleName = "king of sparta",
                        LastName = "I",
                        IsValid = false,
                        RegistrationDate = DateTime.Now,
                        Picture = ConvertImageToByteArray(string.Format(imagesDir, "leonid.jpg"))
                        }
                };

                visitorsList.ForEach(n => db.Visitors.Add(n));

                db.SaveChanges();
            }
        }

        public static byte[] ConvertImageToByteArray(string filePath)
        {
            FileStream stream = new FileStream(
                filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            byte[] photo = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();

            return photo;
        }


    }
}
