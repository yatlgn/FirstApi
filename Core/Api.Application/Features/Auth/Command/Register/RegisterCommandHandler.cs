using Api.Application.Bases;
using Api.Application.Features.Auth.Rules;
using Api.Application.Interfaces;
using Api.Application.Interfaces.AutoMapper;
using Api.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Auth.Command.Register
{
    public class RegisterCommandHandler : BaseHandler, IRequestHandler<RegisterCommandRequest, Unit>
    {
        private readonly AuthRules authRules;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<Role> roleManager;
        public RegisterCommandHandler(AuthRules authRules, UserManager<User> userManager,RoleManager<Role> roleManager,IMapper mapper,IUnitOfWork unitOfWork,IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            this.authRules = authRules;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public async Task<Unit> Handle(RegisterCommandRequest request, CancellationToken cancellationToken)
        {
            try
            {
                await authRules.UserShouldNotBeExist(await userManager.FindByEmailAsync(request.Email));
                User user = mapper.Map<User, RegisterCommandRequest>(request);
                user.UserName = request.Email;
                user.SecurityStamp = Guid.NewGuid().ToString();
                IdentityResult result = await userManager.CreateAsync(user, request.Password);
                if (result.Succeeded)
                {
                    if (!await roleManager.RoleExistsAsync("user"))
                    {
                        await roleManager.CreateAsync(new Role
                        {
                            Id = Guid.NewGuid(),
                            Name = "user",
                            NormalizedName = "USER",
                            ConcurrencyStamp = Guid.NewGuid().ToString(),
                        });
                    }
                    await userManager.AddToRoleAsync(user, "user");
                }
                else
                {
                    // IdentityResult başarısızsa hataları toplayın ve fırlatın
                    var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                    throw new Exception($"User creation failed: {errors}");
                }

                return Unit.Value;
            }
            catch (Exception ex)
            {
                // Inner exception'ı yakalayın ve fırlatın
                throw new Exception("An error occurred while saving the entity changes.", ex);
            }
        }
    }
}
