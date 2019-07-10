using System;

namespace Crafted.Data.Interfaces
{
    public interface ITrackable
    {
        int Id { get; set; }

        DateTimeOffset DateCreated { get; set; }

        DateTimeOffset? DateModified { get; set; }

        string ChangedBy { get; set; }
    }
}
