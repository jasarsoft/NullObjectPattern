namespace NullObject.Entities
{
    class NullLerner : ILearner
    {
        public int Id => -1;

        public string UserName => "Just Browsing";

        public int CoursesCompleted => 0;
    }
}