using System;

namespace CourseWorkWinForms
{

    abstract class QuestionCreator
    {
        public abstract IQuestion FactoryMethod();

        public IQuestion CreateQuestion()
        {
            return FactoryMethod();
        }
    }

    class OneRightVariantQuestionCreator : QuestionCreator
    {
        public override IQuestion FactoryMethod()
        {
            return new OneRightVariantQuestion();
        }
    }

    class SomeRightVariantsQuestionCreator : QuestionCreator
    {
        public override IQuestion FactoryMethod()
        {
            return new SomeRightVariantsQuestion();
        }
    }

    class DetailedAnswerCreator : QuestionCreator
    {
        public override IQuestion FactoryMethod()
        {
            return new DetailedAnswer();
        }
    }
    

}