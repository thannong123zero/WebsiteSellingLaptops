using AutoMapper;
using BusinessLogic.ViewModel;
using DataAccess.IRepositories.IProducerRepository;
using MediatR;

namespace BusinessLogic.UseCase.Crud.Producer.Query.GetProducers
{
    public class GetProducersHandler : IRequestHandler<GetProducersRequest, List<ProducerViewModel>>
    {
        private readonly IProducerQueryRepository _producerQueryRepository;
        private readonly IMapper _mapper;
        public GetProducersHandler(IProducerQueryRepository producerQueryRepository,
        IMapper mapper)
        {
            _producerQueryRepository = producerQueryRepository;
            _mapper = mapper;
        }
        public async Task<List<ProducerViewModel>> Handle(GetProducersRequest request, CancellationToken cancellationToken)
        {
            var listProducer = await _producerQueryRepository.GetAllAsync();

            List<ProducerViewModel> result = new List<ProducerViewModel>();

            listProducer.ForEach(s => result.Add(_mapper.Map<ProducerViewModel>(s)));

            return result;
        }
    }
}
