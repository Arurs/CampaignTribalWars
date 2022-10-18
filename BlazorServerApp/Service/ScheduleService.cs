using BlazorServerApp.Data;
using BlazorServerApp.Pages;

namespace BlazorServerApp.Service
{
    public class ScheduleService
    {
        public async Task<Command[]> GetSampleSchedules()
        {
            Command[] commands = new Command[] {
                                new Command ()
                {
                    Id =0,
                    CommandType = CommandType.OFF,
                    Link = "Link",
                    MinTime = DateTime.Now.AddMinutes(-121),
                    MaxTime = DateTime.Now.AddMinutes(-71),
                },
                new Command ()
                {
                    Id =1,
                    CommandType = CommandType.OFF,
                    Link = "Link",
                    MinTime = DateTime.Now.AddMinutes(-11),
                    MaxTime = DateTime.Now.AddMinutes(71),
                },
                new Command ()
                {
                    Id =2,
                    CommandType = CommandType.NOBLe,
                    Link = "Link",
                    MinTime = DateTime.Now.AddMinutes(61),
                    MaxTime = DateTime.Now.AddMinutes(92),
                },
                new Command ()
                {
                    Id =3,
                    CommandType = CommandType.FAKE,
                    Link = "Link",
                    MinTime = DateTime.Now.AddMinutes(4),
                    MaxTime = DateTime.Now.AddMinutes(190),
                }};
            return commands;
        }
    }
}
