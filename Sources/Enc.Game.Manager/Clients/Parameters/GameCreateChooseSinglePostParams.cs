using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enc.Game.Manager.Clients.Parameters
{
    public class GameCreateChooseSinglePostParams
    {
        public string gameTypeID { get; set; }
        public string ddlAuthorsCompexity { get; set; }
        public string hideGameFromCalendar { get; set; }
        public string fee { get; set; }
        public string isModerated { get; set; }
        public string feeCurrency { get; set; }
        public string firstPlaces { get; set; }
        public string gameTitle { get; set; }
        public string prize { get; set; }
        public string certificateMode { get; set; }
        public string notFirstPlaces { get; set; }
        public string gameStatAvailabilityList { get; set; }
        public string action { get; set; }
        public string gameAutorsByCommas { get; set; }
        public string requestLastDate { get; set; }
        public string chkShowFinishPlace { get; set; }
        public string radioAcceptRateMode { get; set; }
        public string maxPlayers { get; set; }
        public string maxTeamPlayers { get; set; }
        public string showFeeList { get; set; }
        public string gameZoneList { get; set; }
        public string finishDateTime { get; set; }
        public string gameScenarioAvailabilityList { get; set; }
        public string startDateTime { get; set; }
        public string txtAcceptRateFrom { get; set; }
        public string feeName { get; set; }
        public string descriptionHtml { get; set; }
    }
}
