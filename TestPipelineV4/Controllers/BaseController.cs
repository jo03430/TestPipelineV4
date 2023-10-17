using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TestPipelineV4.Controllers;

//[Authorize]
//[ProducesResponseType(StatusCodes.Status401Unauthorized)]
[ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
public class BaseController : ControllerBase
{

}