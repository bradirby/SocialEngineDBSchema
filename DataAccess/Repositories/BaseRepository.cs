using System;
using NPoco;
using SocialEngine.DataAccess.Interfaces;

namespace SocialEngine.DataAccess.Repositories
{
    public class BaseRepository<T> :IBaseRepository<T> where T : class
    {
        protected Snapshot<T> snapShot;
        protected readonly IDbFactory dbFactory;

        public BaseRepository(IDbFactory dbFactory) 
        {
            this.dbFactory = dbFactory;
        }
        /// <summary>
        /// This should only be used if you need a different connection than the one in the dbFactory that was passed in
        /// </summary>
        /// <returns></returns>
        protected IDatabase GetConnection()
        {
            var connection = dbFactory.GetConnection();
            connection.OpenSharedConnection();
            return connection;
        }

        protected void CloseConnection(IDatabase connection)
        {
            connection.CloseSharedConnection();
            connection.Dispose();
        }

        public virtual void Insert(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            try
            {
                using (var db = dbFactory.GetConnection())
                {
                    db.Insert(entity);
                    CloseConnection(db);
                }
            }
            catch (Exception ex)
            {
                //logger.LogError("Error in BaseRepository", ex);
                throw;
            }
        }

        public virtual void Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            try
            {
                using (var db = dbFactory.GetConnection())
                {
                    db.Delete(entity);
                    this.CloseConnection(db);
                }
            }
            catch (Exception ex)
            {
                //logger.LogError("Error in BaseRepository", ex);
                throw;
            }
        }

        public virtual void Delete(object primaryKey)
        {
            if (primaryKey == null) throw new ArgumentNullException(nameof(primaryKey));
            try
            {
                using (var db = dbFactory.GetConnection())
                {
                    db.Delete<T>(primaryKey);
                    this.CloseConnection(db);
                }
            }
            catch (Exception ex)
            {
                //logger.LogError("Error in BaseRepository", ex);
                throw;
            }
        }

        public virtual void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            try
            {
                using (var db = this.GetConnection())
                {
                    db.Update(entity);
                    CloseConnection(db);
                }
            }
            catch (Exception ex)
            {
                //logger.LogError("Error in BaseRepository", ex);
                throw;
            }
        }

        public virtual void Update(T entity, Snapshot<T> snapshot)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            try
            {
                using (var db = this.GetConnection())
                {
                    db.Update(entity, snapShot.UpdatedColumns());
                    CloseConnection(db);
                }
            }
            catch (Exception ex)
            {
                //logger.LogError("Error in BaseRepository", ex);
                throw;
            }
        }

        public virtual Snapshot<T> GetSnapshot(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            try
            {
                using (var db = dbFactory.GetConnection())
                {
                    snapShot = db.StartSnapshot(entity);
                    CloseConnection(db);
                    return snapShot;
                }
            }
            catch (Exception ex)
            {
                //logger.LogError("Error in BaseRepository", ex);
                throw;
            }
        }


        public T GetById(int id)
        {
            using (var db = dbFactory.GetConnection())
            {
                var usr = db.SingleOrDefaultById<T>(id);
                return usr;
            }
        }


    }
}