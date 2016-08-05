using System.Collections.Generic;

namespace Katas {
    public class BowlingGame {
        private List<int> _rolls = new List<int>();

        public int Roll(int pins) {
            _rolls.Add(pins);
            return pins;
        }

        public int Score() {
            var score = 0;
            var frameIndex = 0;
            var frame = 0;
            while (frame < 10) {
                if (_rolls[frame] == 10) {
                    score += 10 + _rolls[frame + 1] + _rolls[frame + 2];
                    frameIndex += 1;
                } else if (_rolls.Count > frame + 1 && _rolls[frame] + _rolls[frame + 1] == 10) {
                    score += 10 + _rolls[frame + 2];
                    frameIndex += 2;
                } else {
                    score += _rolls[frame] + _rolls[frame + 1];
                    frameIndex += 2;
                }
                frame += 1;
            }
            return score;
        }
    }
}