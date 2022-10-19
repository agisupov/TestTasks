global using MeetingConsoleApp.Controllers;
global using MeetingConsoleApp.Entities;
global using MeetingConsoleApp.Models;
global using MeetingConsoleApp.Services;

var reminder = new Reminder();
reminder.Run();
MenuWorker.Run();