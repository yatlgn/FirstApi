using Api.Application.Interfaces;
using Api.Application.Interfaces.AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Security.Claims;

namespace Api.Application.Bases
{
    public class BaseHandler
    {
        public readonly IMapper mapper;
        public readonly IUnitOfWork unitOfWork;
        public readonly IHttpContextAccessor httpContextAccessor;
        public Guid UserId { get; }

        public BaseHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            this.httpContextAccessor = httpContextAccessor;

            // Güvenli bir şekilde UserId'yi al
            var httpContext = httpContextAccessor.HttpContext;
            var user = httpContext?.User;

            var userIdClaim = user?.FindFirstValue(ClaimTypes.NameIdentifier);

            if (Guid.TryParse(userIdClaim, out var userId))
            {
                UserId = userId;
            }
            else
            {
                // Hata yönetimi veya varsayılan değer atama
                UserId = Guid.Empty; // veya bir hata işleme mekanizması
            }
        }
    }
}
