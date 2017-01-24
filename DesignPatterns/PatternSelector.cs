using DesignPatterns.PatternsType;

namespace DesignPatterns
{
    public class PatternSelector
    {
        private int _patternIndex;       

        public PatternSelector (int index)
        {
            _patternIndex = index;
        }

        public void SelectPatterns()
        {
            PatternsTypeBase patternsType = null;

            switch (_patternIndex)
            {
                case 1:
                    patternsType = new CreationalType();
                    break;
                case 2:
                    patternsType = new StructuralType();
                    break;
                case 3:
                    patternsType = new Behevioral();
                    break;
                default:
                    break;
            }
            if (patternsType != null)
                patternsType.Execute();
        }

    }
}
