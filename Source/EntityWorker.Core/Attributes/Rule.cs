﻿using System;
using System.Linq;

namespace EntityWorker.Core.Attributes
{
    /// <summary>
    /// https://github.com/AlenToma/EntityWorker.Core/blob/master/Documentation/Attributes.md
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public sealed class Rule : Attribute
    {
        /// <summary>
        /// Rule type which implement interface IDbRuleTrigger
        /// </summary>
        public Type RuleType { get; private set; }

        /// <inheritdoc />
        /// <summary>
        /// Define class rule by adding this attribute
        /// ruleType must inherit from IDbRuleTrigger
        /// ex UserRule : IDbRuleTrigger<User/> which mean that this rule belonging to User
        /// </summary>
        /// <param name="ruleType"></param>
        public Rule(Type ruleType)
        {
            try
            {
                RuleType = ruleType;
                if (ruleType.GetInterfaces().Length <= 0 || !ruleType.GetInterfaces().Any(x => x.ToString().Contains("IDbRuleTrigger")))
                    throw new Exception("RuleType dose not implement interface IDbRuleTrigger<>");
            }
            catch (Exception e)
            {
                GlobalConfiguration.Log?.Error(e);
                throw;
            }
        }
    }
}
