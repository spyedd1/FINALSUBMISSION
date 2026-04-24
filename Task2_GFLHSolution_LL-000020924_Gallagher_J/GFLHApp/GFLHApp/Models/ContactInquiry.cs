namespace GFLHApp.Models
{
    // Stores a single message sent from the public Contact Us page and any admin reply attached to it.
    public class ContactInquiry
    {

        public int ContactInquiryId { get; set; }  // Primary key for the saved inquiry record.

        public string FullName { get; set; } = string.Empty; // Stores the sender's display name from the contact form.

        public string EmailAddress { get; set; } = string.Empty; // Stores the email address used to match signed-in users to their inquiries and replies.

        public string Subject { get; set; } = string.Empty; // Stores the short summary line entered by the customer.

        public string Message { get; set; } = string.Empty; // Stores the customer's full message body.

        public DateTime SubmittedAtUtc { get; set; } // Records when the inquiry was first submitted.

        public bool IsRead { get; set; } // Tracks whether an admin has reviewed the inquiry.

        public DateTime? ReadAtUtc { get; set; } // Records when the inquiry was marked as read.

        public string AdminReply { get; set; } = string.Empty;  // Stores the latest admin reply shown back to the customer on the contact page.

        public DateTime? RepliedAtUtc { get; set; } // Records when the admin reply was written or last updated.

        public string RepliedByEmail { get; set; } = string.Empty;  // Stores which admin account wrote the reply.
    }
}
