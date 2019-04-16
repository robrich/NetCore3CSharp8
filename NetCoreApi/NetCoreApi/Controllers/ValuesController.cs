using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using NetCoreApi.Models;

namespace NetCoreApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		// GET api/values
		[HttpGet]
		[ProducesResponseType(200)]
		public ActionResult<List<ValueData>> Get()
		{
			return new List<ValueData>
			{
				new ValueData
				{
					Id = 1,
					Value = "value"
				},
					new ValueData
				{
					Id = 2,
					Value = "gone"
				}
			};
		}

		// GET api/values/5
		[HttpGet("{id}")]
		[ProducesResponseType(200)]
		[ProducesResponseType(404)]
		public ActionResult<ValueData> Get(int id)
		{
			return new ValueData
			{
				Id = id,
				Value = "value"
			};
		}

		// POST api/values
		[HttpPost]
		[ProducesResponseType(201)]
		[ProducesResponseType(400)]
		public ActionResult<ValueData> Post([Required]string value)
		{
			return CreatedAtRoute("Get", routeValues: new { id = 1 }, value: new ValueData
			{
				Id = 1,
				Value = value
			});
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		[ProducesResponseType(200)]
		[ProducesResponseType(400)]
		public ActionResult<ValueData> Put(int id, [Required]string value)
		{
			if (id == 2)
			{
				return NotFound();
			}
			return new ValueData
			{
				Id = id,
				Value = value
			};
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		[ProducesResponseType(200)]
		public ActionResult<ValueData> Delete(int id)
		{
			return Ok();
		}

	}
}
