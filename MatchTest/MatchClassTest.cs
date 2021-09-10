using NUnit.Framework;
using UnitTestAvTippeKupongEnKamp;


namespace MatchTest
{
    public class Tests
    {
      

        [Test]
        public void TestStilling()
        {
         
            var match = new Match();

            match.Goals(true);
            

            var actualDescription = match.ScoreText();
            var expectedDescription = "Stillingen er: 1 - 0";

            Assert.AreEqual(expectedDescription, actualDescription );
        }

        [Test]
        public void TestTippetRiktig()
        {
            var bet = "H";
            var match = new Match(bet);

            match.Goals(true);


            var actualDescription = match.AreBetCorrectText();
            var expectedDescription = "Du tippet riktig";

            Assert.AreEqual(expectedDescription, actualDescription);
        }
        [Test]
        public void TestTippetFeil()
        {
            var bet = "H";
            var match = new Match(bet);

            match.Goals(false);


            var actualDescription = match.AreBetCorrectText();
            var expectedDescription = "Du tippet feil";

            Assert.AreEqual(expectedDescription, actualDescription);
        }
        [Test]
        public void TestTippetFlereMålUavgjort()
        {
           
            var match = new Match();

            match.Goals(false);
            match.Goals(false);
            match.Goals(true);
            match.Goals(true);
            

            var actualDescription = match.ScoreText();
            var expectedDescription = "Stillingen er: 2 - 2";

            Assert.AreEqual(expectedDescription, actualDescription);
        }
        [Test]
        public void TestTippetFlereMålHjemme()
        {

            var match = new Match();

            match.Goals(false);
            match.Goals(true);
            match.Goals(true);
            match.Goals(true);


            var actualDescription = match.ScoreText();
            var expectedDescription = "Stillingen er: 3 - 1";

            Assert.AreEqual(expectedDescription, actualDescription);
        }



    }
}