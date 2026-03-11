using AiCallingAgent.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AiCallingAgent.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<CallRecord> CallRecords => Set<CallRecord>();
    public DbSet<TranscriptEntry> TranscriptEntries => Set<TranscriptEntry>();
    public DbSet<Lead> Leads => Set<Lead>();
    public DbSet<CallbackRequest> CallbackRequests => Set<CallbackRequest>();
    public DbSet<FaqItem> FaqItems => Set<FaqItem>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<CallRecord>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.TwilioCallSid).HasMaxLength(100).IsRequired();
            entity.Property(x => x.CallerNumber).HasMaxLength(50);
            entity.Property(x => x.Status).HasMaxLength(50).IsRequired();
            entity.Property(x => x.Disposition).HasMaxLength(100);
        });

        modelBuilder.Entity<TranscriptEntry>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Speaker).HasMaxLength(20).IsRequired();
            entity.Property(x => x.Text).IsRequired();
        });

        modelBuilder.Entity<Lead>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).HasMaxLength(200);
            entity.Property(x => x.Phone).HasMaxLength(50);
            entity.Property(x => x.Email).HasMaxLength(200);
            entity.Property(x => x.ProductInterest).HasMaxLength(200);
        });

        modelBuilder.Entity<CallbackRequest>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).HasMaxLength(200);
            entity.Property(x => x.Phone).HasMaxLength(50).IsRequired();
            entity.Property(x => x.PreferredTime).HasMaxLength(200);
            entity.Property(x => x.Reason).IsRequired();
        });

        modelBuilder.Entity<FaqItem>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Question).HasMaxLength(500).IsRequired();
            entity.Property(x => x.Answer).IsRequired();
            entity.Property(x => x.Category).HasMaxLength(100);
        });
    }
}