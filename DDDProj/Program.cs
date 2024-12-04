using DDDProj.Helpers;
using DDDProj.Menu.StartMenu;
using DDDProj.Users;
using System.Text.Json;


MenuManager manager = new();
StartMenu menu = new(manager);
menu.SelectMenu();
UniversalHelpers.loggedInUser = null;