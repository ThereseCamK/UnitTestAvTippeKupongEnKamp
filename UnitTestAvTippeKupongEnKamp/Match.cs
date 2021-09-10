using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestAvTippeKupongEnKamp
{
    public class Match
    {
        private int homeGoals;
        private int awayGoals;
        public bool matchIsRunning { get; private set; }
        private readonly string bet;

        public Match(string bet)
        {
            this.bet = bet;
            matchIsRunning = true;
        }
        public Match()
        {
                
        }

        public void Goals(bool homeTeam)
        {
            if (homeTeam) homeGoals++;
            else awayGoals++;
        }
        public bool IsBetCorrect()
        {
            var result = homeGoals == awayGoals ? "U" : homeGoals > awayGoals ? "H" : "B";

            return bet.Contains(result);
        }

        public void matchIsStoped()
        {
            matchIsRunning = false;
        }

        public string ScoreText()
        {
            return $"Stillingen er: {homeGoals} - {awayGoals}"; 
        }
        public string AreBetCorrectText()
        {
            var isBetCorrectText = IsBetCorrect() ? "riktig" : "feil";

            return $"Du tippet {isBetCorrectText}";
        }
    }
}
