using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FTU_StudentOnlineService
{
    internal class DataValidation
    {
        public bool IsNumeric(string input)
        {
            if (int.TryParse(input, out _))
                return true;
            else
            {
                MessageBox.Show("Invalid input. Please enter a numeric value.");
                return false;
            }
        }

        public bool IsEmailTrueFrom(string gmailAddress, string type)
        {
            UsersDAO usersDAO = new UsersDAO();
            List<Users> usersList = usersDAO.getUsers();
            Users foundUser = usersList?.FirstOrDefault(ur => ur.gmail == gmailAddress);

            if (type =="1")
            {
                if (gmailAddress.EndsWith("@fpt.edu.vn", StringComparison.OrdinalIgnoreCase) && foundUser == null)
                    return true;
                else
                {
                    MessageBox.Show("Invalid Gmail address. Please use an @fpt.edu.vn email or this mail was exits");
                    return false;
                }
            }
            else
            {
                if (gmailAddress.EndsWith("@fpt.edu.vn", StringComparison.OrdinalIgnoreCase))
                    return true;
                else
                {
                    MessageBox.Show("Invalid Gmail address. Please use an @fpt.edu.vn email or this mail was exits");
                    return false;
                }
            }
        }

        public bool IsPhoneNumberValid(string phoneNumber)
        {
            if (phoneNumber.Length == 10 && IsNumeric(phoneNumber))
                return true;
            else
            {
                MessageBox.Show("Invalid phone number. Please enter a 10-digit numeric value.");
                return false;
            }
        }

        public bool IsFileExtensionValid(string filePath, params string[] allowedExtensions)
        {
            string fileExtension = Path.GetExtension(filePath);

            if (allowedExtensions.Any(ext => fileExtension.Equals(ext, StringComparison.OrdinalIgnoreCase)))
                return true;
            else
            {
                MessageBox.Show("Invalid file format. Please choose a valid file extension.");
                return false;
            }
        }
    }
}
