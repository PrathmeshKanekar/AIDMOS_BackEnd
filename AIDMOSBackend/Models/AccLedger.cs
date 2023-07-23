using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Models;

[Table("acc_ledgers")]
public partial class AccLedger
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("businessid", TypeName = "numeric(18, 0)")]
    public decimal? Businessid { get; set; }

    [Column("groupid", TypeName = "numeric(18, 0)")]
    public decimal? Groupid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("address")]
    public string? Address { get; set; }

    [Column("pincode")]
    [StringLength(50)]
    public string? Pincode { get; set; }

    [Column("villageid", TypeName = "numeric(18, 0)")]
    public decimal? Villageid { get; set; }

    [Column("email")]
    public string? Email { get; set; }

    [Column("mobileno")]
    [StringLength(50)]
    public string? Mobileno { get; set; }

    [Column("altmobileno")]
    [StringLength(50)]
    public string? Altmobileno { get; set; }

    [Column("gstno")]
    [StringLength(50)]
    public string? Gstno { get; set; }

    [Column("panno")]
    [StringLength(50)]
    public string? Panno { get; set; }

    [Column("adharno")]
    [StringLength(50)]
    public string? Adharno { get; set; }

    [Column("status")]
    [StringLength(50)]
    public string? Status { get; set; }

    [Column("createdby", TypeName = "numeric(18, 0)")]
    public decimal? Createdby { get; set; }

    [Column("createdon", TypeName = "datetime")]
    public DateTime? Createdon { get; set; }

    [Column("updatedby", TypeName = "numeric(18, 0)")]
    public decimal? Updatedby { get; set; }

    [Column("updatedon", TypeName = "datetime")]
    public DateTime? Updatedon { get; set; }

    [Column("deletedby", TypeName = "numeric(18, 0)")]
    public decimal? Deletedby { get; set; }

    [Column("deletedon", TypeName = "datetime")]
    public DateTime? Deletedon { get; set; }

    [Column("accountno")]
    public string? Accountno { get; set; }

    [Column("ifsccode")]
    public string? Ifsccode { get; set; }

    [Column("branch")]
    public string? Branch { get; set; }

    [Column("openingbalance", TypeName = "numeric(18, 2)")]
    public decimal? Openingbalance { get; set; }

    [Column("contactperson")]
    [StringLength(500)]
    public string? Contactperson { get; set; }

    [Column("creditortype")]
    [StringLength(50)]
    public string? Creditortype { get; set; }

}
