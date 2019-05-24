using System;
using System.Collections.Generic;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using UnitOfWork = TmTech_v1.Interface.UnitOfWork;

namespace TmTech_v1.Bussiness
{
    public class CompanyRequest
    {
        public string Token;
    }
    public class CompanyReponse
    {
        public List<Company> List { get; set; }
    }

   public class CompanyBussiness : ICompanyBussiness
    {

        public bool Delete(Company company)
        {   
            if (company == null)
                return false;
            var resulf = false;
            using (var uow = new UnitOfWork())
            {
                try
                {
                    uow.CompanyRepository.InActive(company);
                    uow.Commit();
                    resulf = true;
                }
                catch (Exception)
                {

                    resulf = false;
                }
            }
            return resulf;
        }

        public bool Delete(string companyId)
        {
            if (string.IsNullOrEmpty(companyId))
            {
                return false;
            }
            bool resulf;
            using (var uow = new UnitOfWork())
            {
                try
                {
                    uow.CompanyRepository.InActive(int.Parse(companyId));
                    uow.Commit();
                    resulf = true;
                }
                catch (Exception)
                {

                    resulf = false;
                }
            }
            return resulf;
        }

        public CompanyReponse GetAll(CompanyRequest companyRequest = null)
        {
            List<Company> list;

            using (IUnitOfWork uow = new UnitOfWork())
            {
                list = uow.CompanyRepository.All();
            }
            return new CompanyReponse()
            {
                List = list

            };
        }

        public int Insert(Company company)
        {
            if (company == null)
                return -1;
            int companyId =0;
            int userId = 0;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    companyId = uow.CompanyRepository.AddandGetCompanyId(company);
                    company.MainDeputy.CompanyId = companyId;
                    company.MainDeputy.UserId = userId;
                    company.CompanyId = companyId;
                    uow.DeputyRepository.Add(company.MainDeputy);
                    uow.Commit();
                }
                catch (Exception)
                {

                    companyId = -1;
                }
            }
            return companyId;
        }

        public int Update(Company company)
        {
            try
            {
            Company companyUPdate = null;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                companyUPdate = uow.CompanyRepository.Find(company.CompanyId);
                
            }
            companyUPdate.CompanyCode = company.CompanyCode;
            companyUPdate.CompanyName = company.CompanyName;
            companyUPdate.Photo = company.Photo;
            companyUPdate.PictureLogo = company.PictureLogo;
            companyUPdate.ClassId = company.ClassId;
            companyUPdate.TypeId = company.TypeId;
            companyUPdate.Address = company.Address;
            companyUPdate.Accountant = company.Accountant;
            companyUPdate.AccountantPhone = company.AccountantPhone;
            companyUPdate.SwiftCode = company.SwiftCode;
            companyUPdate.Taxcode = company.Taxcode;
            companyUPdate.Branch = company.Branch;
            companyUPdate.NumberOfEmployee = company.NumberOfEmployee;
            companyUPdate.Note = company.Note;
            companyUPdate.MainDeputy.Phone = company.MainDeputy.Phone;
            companyUPdate.MainDeputy.DeputyName = company.MainDeputy.DeputyName;
            companyUPdate.MainDeputy.Email = company.MainDeputy.Email;
            companyUPdate.MainDeputy.Sex = company.MainDeputy.Sex;
     

            using (IUnitOfWork uow = new UnitOfWork())
            {
                uow.CompanyRepository.Update(company);
                uow.DeputyRepository.Update(company.MainDeputy);
                uow.Commit();
            }
                return 0;
            }
            catch
            {

                return -1;
            }

        }
        public Company GetById(int companyId)
        {
            if (companyId < 1)
                return null;
            Company company;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                company = uow.CompanyRepository.Find(companyId);

            }
            return company;
        }
        public void EnableActive(int companyId)
        {
            using (IUnitOfWork uow = new UnitOfWork())
            {
                uow.CompanyRepository.EnableActive(companyId);
                uow.Commit();
            }
        }

        public void InActive(int companyId)
        {
            using (IUnitOfWork uow = new UnitOfWork())
            {
                uow.CompanyRepository.InActive(companyId);
                uow.Commit();
            }
        }
    }

}
