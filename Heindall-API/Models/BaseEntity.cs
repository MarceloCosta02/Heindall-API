using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Heindall_API.Models;

public class BaseEntity
{
	[Column("Id")]
	public long? Id { get; private set; }

	public void TornarIdDefault() => Id = null;
}