using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Heindall_API.Models;

public class BaseEntity
{
	[Column("Id")]
	public long? Id { get; set; }

	public void TornarIdDefault() => Id = null;
}