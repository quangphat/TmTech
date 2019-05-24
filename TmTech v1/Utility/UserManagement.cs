using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmTech_v1.Model;
using TmTech_v1.Interface;

namespace TmTech_v1.Utility
{
    public class UserManagement
    {
        private static IDbConnection _db = DbTmTech.DbCon;
        private static List<Permissions> _mLstPermission;
        public static UserSession UserSession;
      

        public static void SetUserSession(Users loginUser)
        {
            UserSession = new UserSession();
            _mLstPermission = new List<Permissions>();
            if (loginUser != null)
            {
                UserSession.Id = loginUser.UserId;
                UserSession.UserName = loginUser.UserName;
                UserSession.Email = loginUser.Email;
                UserSession.GroupId = loginUser.UserGroupId;
                UserSession.GroupName = loginUser.UserGroup.UserGroupName;
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    _mLstPermission = uow.PermissionsRepository.GetPermission(UserSession.GroupId);
                    uow.Commit();
                }
            }
            else
                UserSession = null;
            UserSetting setting;
            setting = UtilityFunction.DeserializeTheme();
            if (setting == null)
                return;
            if (UserSession != null) UserSession.ThemeName = setting.ThemeName;
        }
        public static bool AllowViewOwn(string tablename)
        {
            bool isAllow = false;
            if (string.IsNullOrEmpty(tablename) || string.IsNullOrWhiteSpace(tablename))
                return false;
            if (_mLstPermission == null) return false;
            Permissions exist = _mLstPermission.Where(p => p.ObjectPermissionName == tablename.Trim()).FirstOrDefault();
            if (exist == null) return false;
            if (exist != null)
            {
                if (exist.ViewOwn == true)
                    isAllow = true;
                else
                    isAllow = false;
            }
            return isAllow;
        }
        public static bool AllowViewAll(string tablename)
        {
            bool isAllow = false;
            if (string.IsNullOrEmpty(tablename) || string.IsNullOrWhiteSpace(tablename))
                return false;
            if (_mLstPermission == null) return false;
            Permissions exist = _mLstPermission.Where(p => p.ObjectPermissionName == tablename.Trim()).FirstOrDefault();
            if (exist == null)
                return false;
            if (exist.ViewAll == true)
                isAllow = true;
            return isAllow;
        }
        public static bool AllowCreate(string tablename)
        {
            var isAllow = false;
            if (string.IsNullOrEmpty(tablename) || string.IsNullOrWhiteSpace(tablename))
                return false;
            if (_mLstPermission == null) return false;
            var exist = _mLstPermission.Where(p => p.ObjectPermissionName == tablename.Trim()).FirstOrDefault();
            if (exist == null) return false;
            if (exist != null)
            {
                if (exist.Create == true)
                    isAllow = true;
            }
            return isAllow;
        }
        public static bool AllowEdit(string tablename)
        {
            bool isAllow = false;
            if (string.IsNullOrEmpty(tablename) || string.IsNullOrWhiteSpace(tablename))
                return false;
            if (_mLstPermission == null)
                return false;
            Permissions exist = _mLstPermission.Where(p => p.ObjectPermissionName == tablename.Trim()).FirstOrDefault();
            if (exist == null) return false;

            if (exist.Edit == true)
                isAllow = true;
            return isAllow;
        }
        public static bool AllowDelete(string tablename)
        {
            bool isAllow = false;
            if (string.IsNullOrEmpty(tablename) || string.IsNullOrWhiteSpace(tablename))
                return false;
            if (_mLstPermission == null) return false;
            Permissions exist = _mLstPermission.Where(p => p.ObjectPermissionName == tablename.Trim()).FirstOrDefault();
            if (exist == null) return false;
            if (exist != null)
            {
                if (exist.Delete == true)
                    isAllow = true;
                else
                    isAllow = false;
            }
            return isAllow;
        }
        public static bool AllowApprove(string tablename)
        {
            bool isAllow = false;
            if (string.IsNullOrEmpty(tablename) || string.IsNullOrWhiteSpace(tablename))
                return false;
            if (_mLstPermission == null) return false;
            Permissions exist = _mLstPermission.Where(p => p.ObjectPermissionName == tablename.Trim()).FirstOrDefault();
            if (exist == null) return false;
            if (exist.Approve == true)
                isAllow = true;
            else
                isAllow = false;
            return isAllow;
        }
    }
}
