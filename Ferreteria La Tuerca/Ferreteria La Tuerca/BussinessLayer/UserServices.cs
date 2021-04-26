using System;
using System.Data;
using System.Windows.Forms;
using Ferreteria_La_Tuerca.Entities;
using Ferreteria_La_Tuerca.DataAccesLayer;


namespace Ferreteria_La_Tuerca.BussinessLayer
{
    class UserServices
    {
        public User ValidateUser(string TakeUser, string pass)
        {
            try
            {
                User user = UserDAO.GetUser(TakeUser, pass);
                int resultado = user.Perfil;
                if (resultado == 0)
                {
                    return null;
                }
                else
                {
                    return user;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: ", ex.Message);
                return null;
            }
        }
        public DataTable GetAllUser()
        {
            return UserDAO.GetAllUsers();
        }

    }
}
