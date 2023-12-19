using FlexibleAutomationTool.DL.Models;
using FlexibleAutomationTool.DL.Repository;
using MediatR;
using RepositoryCommandService.Commands;

namespace RepositoryCommandService.CommandHandlers
{
    public class RuleCommandHandler : IRequestHandler<CreateRuleCommmand, bool>
    {
        private readonly IRepository<Rule> _ruleRepository;

        public RuleCommandHandler(IRepository<Rule> ruleRepository)
        {
            _ruleRepository = ruleRepository;
        }

        public Task<bool> Handle(CreateRuleCommmand request, CancellationToken cancellationToken)
        {
            try
            {
                var rule = new Rule()
                {
                    Name = request.Name,
                    ConditionDate = request.ConditionDate,
                    ConditionMessanger = request.ConditionMessanger,
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
