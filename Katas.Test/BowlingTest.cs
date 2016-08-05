using Xunit;
using System.Linq;
using Katas;

namespace KatasTest {
    public class BowlingTest {
        private BowlingGame _subject;

        [Fact]
        public void GutterGame() {
            _subject = new BowlingGame();

            Enumerable.Repeat(0, 20).Select(pins => _subject.Roll(pins)).ToList();

            Assert.Equal(0, _subject.Score());
        }

        [Fact]
        public void AllOnes() {
            _subject = new BowlingGame();

            Enumerable.Repeat(1, 20).Select(pins => _subject.Roll(pins)).ToList();

            Assert.Equal(20, _subject.Score());
        }

        [Fact]
        public void Spare() {
            _subject = new BowlingGame();

            _subject.Roll(9);
            _subject.Roll(1);
            Enumerable.Repeat(1, 18).Select(pins => _subject.Roll(pins)).ToList();

            Assert.Equal(29, _subject.Score());
        }

        [Fact]
        public void Strike() {
            _subject = new BowlingGame();

            _subject.Roll(10);
            Enumerable.Repeat(1, 18).Select(pins => _subject.Roll(pins)).ToList();

            Assert.Equal(30, _subject.Score());
        }

        [Fact]
        public void Perfect() {
            _subject = new BowlingGame();

            Enumerable.Repeat(10, 12).Select(pins => _subject.Roll(pins)).ToList();

            Assert.Equal(300, _subject.Score());
        }
    }
}