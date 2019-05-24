using System;
using System.Collections.Generic;
using TmTech_v1.Interface;
using TmTech_v1.Model;

namespace TmTech_v1.Bussiness
{
    public class SupplierBussiness : ISupplierBussiness
    {
        public int AddandGetSupplierID(Supplier entry)
        {
            Users user = entry.User;
            SubSupplier subSupplier = entry.SubSupplier;
            if (user == null || subSupplier == null)
                return -1;
            int idUser = -1;
            user.SetCreate();
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    idUser = uow.UsersRepository.AddAndGetID(user);
                    if (idUser < 0)
                        return -1;
                    entry.SetCreate();
                    entry.SupplierId = uow.SupplierRepository.AddandGetSupplierID(entry);
                    if (entry.SupplierId < 0)
                        return -1;
                    subSupplier.UserId = idUser;
                    subSupplier.SetCreate();
                    subSupplier.SupplierId = entry.SupplierId;
                    subSupplier.IsMain = true;
                    subSupplier.IsActive = true;
                    uow.SubSupplierRepository.Add(subSupplier);
                    uow.Commit();
                }
            }
            catch (Exception)
            {

                return -2;
             
            }
            
            return entry.SupplierId;
        }

        public GroupSupplier AddandGetSupplierID(Supplier entry,string parrentgroup)
        {
            GroupSupplier groupSuppler = new GroupSupplier();
            Users user = entry.User;
            SubSupplier subSupplier = entry.SubSupplier;
            if (user == null || subSupplier == null)
                groupSuppler = null;
            int idUser = -1;
            user.SetCreate();
            groupSuppler = new GroupSupplier
            {
                GroupName = entry.SupplierName,
                ParentGroup = int.Parse(parrentgroup)

            };
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    idUser = uow.UsersRepository.AddAndGetID(user);
                    if (idUser < 0)
                    {
                        return null;
                    }
                       
                    entry.SetCreate();
                    entry.GroupId = uow.SupplierRepository.AddGroup(groupSuppler);
                    if(entry.GroupId <0)
                    {
                        return null;
                    }
                    groupSuppler.GroupId = entry.GroupId;
                    entry.SupplierId = uow.SupplierRepository.AddandGetSupplierID(entry);
                    if (entry.SupplierId < 0)
                    {
                        return null;
                    }
                    subSupplier.UserId = idUser;
                    subSupplier.SetCreate();
                    subSupplier.SupplierId = entry.SupplierId;
                    subSupplier.IsMain = true;
                    subSupplier.IsActive = true;
                    uow.SubSupplierRepository.Add(subSupplier);
                    uow.Commit();
                }
            }
            catch (Exception)
            {
                    return null;
            }

            return groupSuppler;
        }
        public int AddgetID(GroupSupplier groupsupplier)
        {
            throw new NotImplementedException();
        }

        public List<Supplier> All()
        {
            var list = new List<Supplier>();
            using (IUnitOfWork uow = new UnitOfWork())
            {
                list = uow.SupplierRepository.All();
            }
            return list;
        }

        public void EnableActive(int id)
        {
            throw new NotImplementedException();
        }

        public Supplier Find(int id)
        {
            throw new NotImplementedException();
        }

        public Supplier FindByGroupSupplierID(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Supplier entity)
        {
            throw new NotImplementedException();
        }

        public List<Supplier> SearchSupplier(string keySearch)
        {
            throw new NotImplementedException();
        }

        public int Update(Supplier entry)
        {
            Users user = entry.User;
            SubSupplier subSupplier = entry.SubSupplier;
            if (user == null || subSupplier == null)
                return -1;
            user.SetModify();
            using (IUnitOfWork uow = new UnitOfWork())
            {
                var userUpdate = uow.UsersRepository.Find(user.UserId);
                var supplierUpdate = uow.SupplierRepository.Find(entry.SupplierId);
                if ( userUpdate ==null || supplierUpdate ==null)
                {
                    return -1;
                }
                userUpdate.Email = user.Email;
                userUpdate.FullName = user.FullName;
                userUpdate.SetModify();
                userUpdate.Sex = user.Sex;
                supplierUpdate.SupplierName = entry.SupplierName;
                supplierUpdate.Taxcode = entry.Taxcode;
                supplierUpdate.TypeId = entry.TypeId;
                supplierUpdate.Website = entry.Website;
                supplierUpdate.TagetValue = entry.TagetValue;
                supplierUpdate.SetModify();
                uow.UsersRepository.Update(userUpdate);
                uow.SupplierRepository.Update(supplierUpdate);
                uow.SubSupplierRepository.Update(subSupplier);
                uow.Commit();
            }
            return entry.SupplierId;
        }
    }
}
