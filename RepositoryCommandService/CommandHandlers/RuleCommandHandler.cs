using FlexibleAutomationTool.DL.Models;
using FlexibleAutomationTool.DL.Repository;
using MediatR;
using RepositoryCommandService.Commands;

namespace RepositoryCommandService.CommandHandlers
{
    public class RuleCommandHandler : IRequestHandler<RuleCommand, bool>
    {
        private readonly IRepository<Rule> _ruleRepository;

        public RuleCommandHandler(IRepository<Rule> ruleRepository)
        {
            _ruleRepository = ruleRepository;
        }

        public Task<bool> Handle(RuleCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var rule = new Rule()
                {
                    Name = request.Name,
                    ConditionDate = request.ConditionDate,
                    ConditionMessanger = request.ConditionMessanger,
                    Action = request.Action,
                };

                _ruleRepository.Create(rule);
                _ruleRepository.Save();
            }
            catch
            {
                Task.FromResult(false);
            }

            return Task.FromResult(true);
        }
    }
}
