namespace Heindall_API.Models.DTOs;

public class IntegradorDto : BaseEntity
{
    public string IntegradorNome { get; set; }
    public string IntegradorGrupo { get; set; }
    public string IntegradorEndpoint { get; set; }
    public string IntegradorPublicKey { get; set; }
    public string IntegradorPrivateKey { get; set; }

    public int GrupoId { get; set; }
}
