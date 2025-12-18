//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.DependencyInjection;

//namespace SysPret.Core.Library.Extensions;

//public static class ApiBehaviorConfigurator
//{
//    public static IServiceCollection ConfigureApiBehavior( this IServiceCollection services )
//    {
//        return services.Configure<ApiBehaviorOptions>( options =>
//        {
//            //options.SuppressModelStateInvalidFilter = true;
//            //options.SuppressUseValidationProblemDetailsForInvalidModelStateResponses = false;
//            //options.
//            options.InvalidModelStateResponseFactory = context =>
//            {
//                var errors = context.ModelState.Values.SelectMany( x => x.Errors.Select( e => new Notification() { Message = e.ErrorMessage } ) );
//                return new BadRequestObjectResult( new Invalidation( errors ) );
//            };
//        } );
//    }
//}