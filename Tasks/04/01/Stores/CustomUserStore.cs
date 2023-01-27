using _01.Models;
using _01.Models.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _01.Stores
{
    public class CustomUserStore : UserStore<User>
    {
        public CustomUserStore(DbContext context, IdentityErrorDescriber? describer = null) : base(context, describer)
        {
        }

        public virtual Task SetNameAsync(User user, string name, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            user.Name = name;
            return Task.CompletedTask;
        }

        public virtual Task SetLastLoginTimeAsync(User user, DateTime lastLoginTime, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            user.LastLoginTime = lastLoginTime;
            return Task.CompletedTask;
        }

        public virtual Task SetRegistrationTimeAsync(User user, DateTime registrationTime, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            user.RegistrationTime = registrationTime;
            return Task.CompletedTask;
        }

        public virtual Task SetStatusAsync(User user, Status status, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            user.Status = status;
            return Task.CompletedTask;
        }
    }
}
