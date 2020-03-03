using System.Collections.Generic;

namespace DotNetLaunchDashboard.Models.Responses
{
    public class EventsResponse : MissionHeaderModel
    {
        public IEnumerable<EventModel> Events { get; set; }
    }
}
