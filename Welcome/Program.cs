using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;

namespace Welcome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Names = "Vasil";
            user.Password = "123";
            user.Role = UserRolesEnum.ADMIN;
            user.FacultyNumber = 121221000;
            user.Email = "domiaut1999@gmail.com";
            UserViewModel userViewModel = new UserViewModel(user);
            UserView userView = new UserView(userViewModel);
            userView.display();
        }
    }
}
