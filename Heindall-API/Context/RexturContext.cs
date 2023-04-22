using Heindall_API.Models.Rextur;
using Microsoft.EntityFrameworkCore;

namespace Heindall_API.Context;

public partial class RexturContext : DbContext
{
    public RexturContext() { }

    public RexturContext(DbContextOptions<RexturContext> options)
        : base(options) { }

    public virtual DbSet<Itinerary> Itineraries { get; set; }

    public virtual DbSet<Passenger> Passengers { get; set; }

    public virtual DbSet<Hotel> Hoteis { get; set; }

    public virtual DbSet<ManagementField> ManagedFields { get; set; }

    public virtual DbSet<Onibus> Onibus { get; set; }

    public virtual DbSet<Carro> Carros { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Hotel

        modelBuilder.Entity<Hotel>(entity =>
        {
            entity.HasKey(h => h.Id).HasName("PRIMARY");

            entity.ToTable("hoteis");

            entity.HasIndex(h => h.TicketId, "ticketId");

            entity.Property(h => h.Id).HasColumnName("id");

            entity.Property(h => h.AccomodationDescription)
                .HasColumnName("accomodationDescription")
                .HasMaxLength(100);

            entity.Property(h => h.Address)
                .HasColumnName("address")
                .HasMaxLength(100);

            entity.Property(h => h.BoardType)
                .HasColumnName("boardType")
                .HasMaxLength(100);

            entity.Property(h => h.CategoryType)
                .HasColumnName("categoryType")
                .HasMaxLength(100);

            entity.Property(h => h.CheckInDate)
                .HasColumnName("checkInDate")
                .HasColumnType("datetime");

            entity.Property(h => h.CheckOut)
                .HasColumnName("checkOut")
                .HasColumnType("datetime");

            entity.Property(h => h.City)
                .HasColumnName("city")
                .HasMaxLength(100);

            entity.Property(h => h.Country)
                .HasColumnName("country")
                .HasMaxLength(100);

            entity.Property(h => h.HotelChain)
                .HasColumnName("hotelChain")
                .HasMaxLength(100);

            entity.Property(h => h.HotelName)
                .HasColumnName("hotelName")
                .HasMaxLength(100);

            entity.Property(h => h.NumberOfAdults)
                .HasColumnName("numberOfAdults");

            entity.Property(h => h.NumberOfChild)
                .HasColumnName("numberOfChild");

            entity.Property(h => h.PhoneNumber)
                .HasColumnName("phoneNumber")
                .HasMaxLength(100);

            entity.Property(h => h.RoomType)
                .HasColumnName("roomType")
                .HasMaxLength(100);

            entity.Property(h => h.State)
                .HasColumnName("state")
                .HasMaxLength(100);

            entity.Property(h => h.SupplierId)
                .HasColumnName("supplierId")
                .HasMaxLength(100);
        });


        #endregion Hotel

        #region Onibus

        modelBuilder.Entity<Onibus>(entity =>
        {
            entity.HasKey(o => o.Id).HasName("PRIMARY");

            entity.ToTable("onibus");

            entity.HasIndex(e => e.TicketId, "ticketId");

            entity.Property(o => o.Id).HasColumnName("id");

            entity.Property(o => o.TicketId).HasColumnName("ticketId");

            entity.Property(o => o.BoardingDate)
                .HasColumnType("datetime")
                .HasColumnName("boardingDate");

            entity.Property(o => o.BoardingPlace)
                .HasMaxLength(100)
                .HasColumnName("boardingPlace");

            entity.Property(o => o.BusClass)
                .HasMaxLength(100)
                .HasColumnName("busClass");

            entity.Property(o => o.BusCompanyCode)
                .HasColumnName("busCompanyCode");

            entity.Property(o => o.BusCompanyName)
                .HasMaxLength(100)
                .HasColumnName("busCompanyName");

            entity.Property(o => o.LandingDate)
                .HasColumnType("datetime")
                .HasColumnName("landingDate");

            entity.Property(o => o.LandingPlace)
                .HasMaxLength(100)
                .HasColumnName("landingPlace");
        });


        #endregion Onibus

        #region Management Field

        modelBuilder.Entity<ManagementField>(entity =>
        {
            entity.HasKey(mf => mf.Id).HasName("PRIMARY");

            entity.ToTable("management_fields");

            entity.HasIndex(e => e.TicketId, "ticketId");

            entity.Property(mf => mf.Id).HasColumnName("id");

            entity.Property(mf => mf.TicketId).HasColumnName("ticketId");

            entity.Property(mf => mf.Chave)
                .HasMaxLength(100)
                .HasColumnName("chave");

            entity.Property(mf => mf.NomeCampo)
                .HasMaxLength(100)
                .HasColumnName("nomeCampo");

            entity.Property(mf => mf.Valor)
                .HasMaxLength(100)
                .HasColumnName("valor");
        });


        #endregion Management Field

        #region Carro

        modelBuilder.Entity<Carro>(entity =>
        {
            entity.HasKey(c => c.Id).HasName("PRIMARY");

            entity.ToTable("carros");

            entity.HasIndex(e => e.TicketId, "ticketId");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(c => c.CancellationDeadline)
                .HasMaxLength(100)
                .HasColumnName("cancellationDeadline");

            entity.Property(c => c.CategoryCode)
                .HasMaxLength(100)
                .HasColumnName("categoryCode");

            entity.Property(c => c.CategoryTypeCode)
                .HasMaxLength(100)
                .HasColumnName("categoryTypeCode");

            entity.Property(c => c.CodCia)
                .HasMaxLength(100)
                .HasColumnName("codCia");

            entity.Property(c => c.DeliverShopId)
                .HasColumnName("deliverShopId");

            entity.Property(c => c.Description)
                .HasMaxLength(100)
                .HasColumnName("description");

            entity.Property(c => c.DevolutionDate)
                .HasMaxLength(100)
                .HasColumnName("devolutionDate");

            entity.Property(c => c.NumberOfBaggages)
                .HasMaxLength(100)
                .HasColumnName("numberOfBaggages");

            entity.Property(c => c.NumberOfPassengers)
                .HasMaxLength(100)
                .HasColumnName("numberOfPassengers");

            entity.Property(c => c.NumberOfPorts)
                .HasMaxLength(100)
                .HasColumnName("numberOfPorts");

            entity.Property(c => c.Provider)
                .HasMaxLength(100)
                .HasColumnName("provider");

            entity.Property(c => c.ProviderCode)
                .HasMaxLength(100)
                .HasColumnName("providerCode");

            entity.Property(c => c.Type)
                .HasMaxLength(100)
                .HasColumnName("type");

            entity.Property(c => c.WithdrawalDate)
                .HasMaxLength(100)
                .HasColumnName("withdrawalDate");

            entity.Property(e => e.TicketId)
                .HasMaxLength(100)
                .HasColumnName("ticketId");
        });

        #endregion Carro

        #region Itinerary

        modelBuilder.Entity<Itinerary>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("itinerary");

            entity.HasIndex(e => e.TicketId, "ticketId");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.AirlineCode)
                .HasMaxLength(255)
                .HasColumnName("airlineCode");

            entity.Property(e => e.ArrivalDate)
                .HasColumnType("date")
                .HasColumnName("arrivalDate");

            entity.Property(e => e.ArrivalTime)
                .HasMaxLength(255)
                .HasColumnName("arrivalTime");

            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");

            entity.Property(e => e.DepartureTime)
                .HasMaxLength(255)
                .HasColumnName("departureTime");

            entity.Property(e => e.Destination)
                .HasMaxLength(255)
                .HasColumnName("destination");

            entity.Property(e => e.FareBase)
                .HasMaxLength(255)
                .HasColumnName("fareBase");

            entity.Property(e => e.FlightNumber)
                .HasMaxLength(255)
                .HasColumnName("flightNumber");

            entity.Property(e => e.Origin)
                .HasMaxLength(255)
                .HasColumnName("origin");

            entity.Property(e => e.SeatClass)
                .HasMaxLength(255)
                .HasColumnName("seatClass");

            entity.Property(e => e.TicketId).HasColumnName("ticketId");
        });

        #endregion Itinerary

        #region Passenger

        modelBuilder.Entity<Passenger>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("passenger");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.BirthDate)
                .HasColumnType("date")
                .HasColumnName("birthDate");

            entity.Property(e => e.Cpf)
                .HasMaxLength(255)
                .HasColumnName("cpf");

            entity.Property(e => e.Ddd)
                .HasMaxLength(255)
                .HasColumnName("ddd");

            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");

            entity.Property(e => e.FaixaEtaria)
                .HasMaxLength(255)
                .HasColumnName("faixaEtaria");

            entity.Property(e => e.Gender)
                .HasMaxLength(255)
                .HasColumnName("gender");

            entity.Property(e => e.Passport)
                .HasMaxLength(255)
                .HasColumnName("passport");

            entity.Property(e => e.PaxId).HasColumnName("paxId");

            entity.Property(e => e.PaxLastName)
                .HasMaxLength(255)
                .HasColumnName("paxLastName");

            entity.Property(e => e.PaxMiddleName)
                .HasMaxLength(255)
                .HasColumnName("paxMiddleName");

            entity.Property(e => e.PaxName)
                .HasMaxLength(255)
                .HasColumnName("paxName");

            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .HasColumnName("phone");

            entity.Property(e => e.Redress)
                .HasMaxLength(255)
                .HasColumnName("redress");

            entity.Property(e => e.Rg)
                .HasMaxLength(255)
                .HasColumnName("rg");
        });

        #endregion Passenger

        #region Ticket

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("ticket");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.AgencyId).HasColumnName("agencyId");

            entity.Property(e => e.AutorizerList)
                .HasMaxLength(255)
                .HasColumnName("autorizerList");

            entity.Property(e => e.BookClaimer)
                .HasMaxLength(255)
                .HasColumnName("bookClaimer");

            entity.Property(e => e.Capturado).HasColumnName("capturado");

            entity.Property(e => e.CcAmount).HasColumnName("ccAmount");

            entity.Property(e => e.CcAuth)
                .HasMaxLength(255)
                .HasColumnName("ccAuth");

            entity.Property(e => e.CcAuthRav)
                .HasMaxLength(255)
                .HasColumnName("ccAuthRav");

            entity.Property(e => e.CcBandeiraRav)
                .HasMaxLength(255)
                .HasColumnName("ccBandeiraRav");

            entity.Property(e => e.CcNum)
                .HasMaxLength(255)
                .HasColumnName("ccNum");

            entity.Property(e => e.CcNumRav)
                .HasMaxLength(255)
                .HasColumnName("ccNumRav");

            entity.Property(e => e.ClaimerId).HasColumnName("claimerId");

            entity.Property(e => e.ClaimerName)
                .HasMaxLength(255)
                .HasColumnName("claimerName");

            entity.Property(e => e.FormsOfPayment)
                .HasMaxLength(255)
                .HasColumnName("formOfPayment");

            entity.Property(e => e.ClientCode)
                .HasMaxLength(255)
                .HasColumnName("clientCode");

            entity.Property(e => e.ComissionPercent).HasColumnName("comissionPercent");

            entity.Property(e => e.ComissionValue).HasColumnName("comissionValue");

            entity.Property(e => e.CompanyFormalName)
                .HasMaxLength(255)
                .HasColumnName("companyFormalName");

            entity.Property(e => e.CompanyId).HasColumnName("companyId");

            entity.Property(e => e.CompanyName)
                .HasMaxLength(255)
                .HasColumnName("companyName");

            entity.Property(e => e.CostCenterId).HasColumnName("costCenterId");

            entity.Property(e => e.CostCenterName)
                .HasMaxLength(255)
                .HasColumnName("costCenterName");

            entity.Property(e => e.Cpf)
                .HasMaxLength(255)
                .HasColumnName("cpf");

            entity.Property(e => e.Currency)
                .HasMaxLength(255)
                .HasColumnName("currency");

            entity.Property(e => e.CurrencyValue).HasColumnName("currencyValue");

            entity.Property(e => e.Department)
                .HasMaxLength(255)
                .HasColumnName("department");

            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");

            entity.Property(e => e.Emd).HasColumnName("emd");

            entity.Property(e => e.Fare).HasColumnName("fare");

            entity.Property(e => e.FeeBrl).HasColumnName("feeBRL");

            entity.Property(e => e.FeeCliAmount).HasColumnName("feeCliAmount");

            entity.Property(e => e.FeeTotal).HasColumnName("feeTotal");

            entity.Property(e => e.FreeText)
                .HasMaxLength(255)
                .HasColumnName("freeText");

            entity.Property(e => e.GroupId).HasColumnName("groupId");

            entity.Property(e => e.GroupName)
                .HasMaxLength(255)
                .HasColumnName("groupName");

            entity.Property(e => e.Incentive).HasColumnName("incentive");

            entity.Property(e => e.Installments).HasColumnName("installments");

            entity.Property(e => e.IssueDate)
                .HasColumnType("date")
                .HasColumnName("issueDate");

            entity.Property(e => e.IssueType)
                .HasMaxLength(255)
                .HasColumnName("issueType");

            entity.Property(e => e.IssuerUser)
                .HasMaxLength(255)
                .HasColumnName("issuerUser");

            entity.Property(e => e.Loc)
                .HasMaxLength(255)
                .HasColumnName("loc");

            entity.Property(e => e.NumOp)
                .HasMaxLength(255)
                .HasColumnName("numOP");

            entity.Property(e => e.OriginalFare).HasColumnName("originalFare");

            entity.Property(e => e.OriginalTktNum)
                .HasMaxLength(255)
                .HasColumnName("originalTktNum");

            entity.Property(e => e.PassengerName)
                .HasMaxLength(255)
                .HasColumnName("passengerName");

            entity.Property(e => e.PaxName)
                .HasMaxLength(255)
                .HasColumnName("paxName");

            entity.Property(e => e.Penalty).HasColumnName("penalty");

            entity.Property(e => e.ProductType)
                .HasMaxLength(255)
                .HasColumnName("productType");

            entity.Property(e => e.Rav).HasColumnName("rav");

            entity.Property(e => e.Reason)
                .HasMaxLength(255)
                .HasColumnName("reason");

            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("status");

            entity.Property(e => e.TaxaOb).HasColumnName("taxaOb");

            entity.Property(e => e.TktNum)
                .HasMaxLength(255)
                .HasColumnName("tktNum");

            entity.Property(e => e.YqTax).HasColumnName("yqTax");

            entity.HasMany(t => t.Itineraries)
                .WithOne(i => i.Ticket)
                .HasForeignKey(i => i.TicketId);

            entity.HasMany(t => t.Passengers)
                .WithOne(i => i.Ticket)
                .HasForeignKey(i => i.TicketId);

            entity.HasMany(e => e.Carros)
                .WithOne(i => i.Ticket)
                .HasForeignKey(i => i.TicketId);

            entity.HasMany(e => e.Onibus)
                .WithOne(i => i.Ticket)
                .HasForeignKey(i => i.TicketId);

            entity.HasMany(e => e.ManagementFields)
                .WithOne(i => i.Ticket)
                .HasForeignKey(i => i.TicketId);

            entity.HasMany(e => e.Hoteis)
                .WithOne(i => i.Ticket)
                .HasForeignKey(i => i.TicketId);
        });

        #endregion Ticket

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
