using AutoMapper;
using BusinessLogic.ViewModel;
using DataAccess.EntityModel;
using DataAccess.IRepositories;
using DataAccess.IRepositories.IProducerRepository;
using MediatR;

namespace BusinessLogic.UseCase.Crud.Producer.Command.AddProducer
{
    public class AddProducerHandler : IRequestHandler<AddProducerRequest, ProducerViewModel>
    {

        public readonly IProducerQueryRepository _producerQueryRepository;
        public readonly IProducerCommandRepository _producerCommandRepository;
        public readonly IUnitOfWork _unitOfWork;
        public readonly IMapper _mapper;
         public AddProducerHandler(IProducerQueryRepository producerQueryRepository,
             IProducerCommandRepository producerCommandRepository,
             IUnitOfWork unitOfWork,
             IMapper mapper)
        {
            _producerQueryRepository = producerQueryRepository;
            _producerCommandRepository = producerCommandRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ProducerViewModel> Handle(AddProducerRequest request, CancellationToken cancellationToken)
        {
            var model = _mapper.Map<ProducerModel>(request);
            _producerCommandRepository.Add(model);
            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<ProducerViewModel>(model);
        }
    }
}
