using AutoMapper;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Interfaces;

namespace IntegraBrasilApi.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public EnderecoService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        async Task<ResponseGenerico<EnderecoResponse>> IEnderecoService.BuscarEnderecoPorCEP(string cep)
        {
            var endereco = await _brasilApi.BuscarEnderecoPorCEP(cep);
            return _mapper.Map<ResponseGenerico<EnderecoResponse>>(endereco);
        }
    }
}