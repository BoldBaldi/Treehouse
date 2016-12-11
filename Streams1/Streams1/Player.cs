using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streams1
{
        public class RootObject
        {
            public Player[] Player { get; set; }
        }

        public class Player
        {
            public int Assists { get; set; }
            public int BigChancesCreated { get; set; }
            public int Blocks { get; set; }
            public int? ChanceOfPlayingNextRound { get; set; }
            public int? ChanceOfPlayingThisRound { get; set; }
            public int CleanSheets { get; set; }
            public int Clearances { get; set; }
            public int Code { get; set; }
            public int CostChangeEvent { get; set; }
            public int CostChangeEventFall { get; set; }
            public int CostChangeStart { get; set; }
            public int CostChangeStartFall { get; set; }
            public int Crosses { get; set; }
            public int DreamteamCount { get; set; }
            public int ElementType { get; set; }
            public string EpNext { get; set; }
            public string EpThis { get; set; }
            public int ErrorsLeadingToGoal { get; set; }
            public int EventPoints { get; set; }
            public string FirstName { get; set; }
            public string Form { get; set; }
            public int GoalsConceded { get; set; }
            public int GoalsScored { get; set; }
            public int Id { get; set; }
            public bool InDreamteam { get; set; }
            public int Interceptions { get; set; }
            public int KeyPasses { get; set; }
            public int LoanedIn { get; set; }
            public int LoanedOut { get; set; }
            public int LoansIn { get; set; }
            public int LoansOut { get; set; }
            public int Minutes { get; set; }
            public string News { get; set; }
            public int NowCost { get; set; }
            public int OwnGoalEarned { get; set; }
            public int OwnGoals { get; set; }
            public int PassCompletion { get; set; }
            public int PenaltiesConceded { get; set; }
            public int PenaltiesEarned { get; set; }
            public int PenaltiesMissed { get; set; }
            public int PenaltiesSaved { get; set; }
            public string Photo { get; set; }
            public string PointsPerGame { get; set; }
            public string Position { get; set; }
            public int Recoveries { get; set; }
            public int RedCards { get; set; }
            public int Saves { get; set; }
            public string SecondName { get; set; }
            public string SelectedByPercent { get; set; }
            public int Shots { get; set; }
            public bool Special { get; set; }
            public string Status { get; set; }
            public int Tackles { get; set; }
            public int Team { get; set; }
            public string TeamName { get; set; }
            public int TotalPoints { get; set; }
            public int TransfersIn { get; set; }
            public int TransfersInEvent { get; set; }
            public int TransfersOut { get; set; }
            public int TransfersOutEvent { get; set; }
            public string ValueForm { get; set; }
            public string ValueSeason { get; set; }
            public int WasFouled { get; set; }
            public string WebName { get; set; }
            public int YellowCards { get; set; }
        }
}
