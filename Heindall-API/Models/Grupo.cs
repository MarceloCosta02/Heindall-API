﻿namespace Heindall_API.Models;

public class Grupo : BaseEntity
{
	public string GrupoName { get; set; }
	public string GrupoDescription { get; set; }
	public string GrupoArea { get; set; }
	public string GrupoURL { get; set; }//como adicionar um combobox na view?
	public string GrupoMetodo { get; set; }//API 1, 2?SOAP?
	public string GrupoType { get; set; }
	public string GrupoUser { get; set; }
	public string GrupoPassword { get; set; }
	public int GrupoPort { get; set; }
	public string PublicKey { get; set; }
	public string PrivateKey { get; set; }
}
