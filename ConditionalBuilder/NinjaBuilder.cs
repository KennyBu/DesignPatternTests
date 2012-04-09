using System;
using System.Collections.Generic;

namespace ConditionalBuilder
{
    public class NinjaBuilder
    {
        private readonly List<Action<Ninja>> _builderActions;


        public static NinjaBuilder CreateNinjaBuilder()
        {
            return new NinjaBuilder();
        }
        
        public NinjaBuilder()
        {
             _builderActions = new List<Action<Ninja>>();
        }

        public NinjaBuilder AtLevel(int level)
        {
            _builderActions.Add(n => n.Level = level);

            return this;
        }
        
        public NinjaBuilder WithShurikens(int numShirukens)
        {
            _builderActions.Add(n => n.Shirukens = numShirukens);

            return this;
        }

        public NinjaBuilder WithSkill(string skill)
        {
            _builderActions.Add(s => s.Skill = skill);

            return this;
        }

        public NinjaBuilder When(Func<Boolean> condition)
        {
            var result = condition.Invoke();

            if (!result)
            {
                var oldAction = _builderActions[_builderActions.Count - 1];
                _builderActions.Remove(oldAction);
            }

            return this;
        }

        public Ninja Build()
        {
            var ninja = new Ninja();
            _builderActions.ForEach(ba => ba(ninja));
            
            return ninja;
        }

    }
}