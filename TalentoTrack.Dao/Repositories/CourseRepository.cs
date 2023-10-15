using TalentoTrack.Dao.DB;
using TalentoTrack.Common.Entities;
using TalentoTrack.Common.Repositories;
using TalentoTrack.Common.DTOs.Courses;
using Microsoft.EntityFrameworkCore;
using TalentoTrack.Common.DTOs.Account;
using Azure.Core;

namespace TalentoTrack.Dao.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        public TalentoTrack_DbContext _dbContext;

        public CourseRepository(TalentoTrack_DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> InsertUpdate(Course course)
        {
            if (course.Id == 0)
                _dbContext.tbl_courses.Add(course);
            else
            {
                var dbRecord = await _dbContext.tbl_courses.FindAsync(course.Id);

                if (dbRecord != null)
                {
                    dbRecord.Name = course.Name;
                    dbRecord.TotalFees = course.TotalFees;
                    dbRecord.DurationInDays = course.DurationInDays;
                    dbRecord.UpdatedById = course.UpdatedById;
                    dbRecord.UpdateDateTime = course.UpdateDateTime;
                }
                else
                    throw new Exception("Invalid course Id.");
            }

            bool result = await _dbContext.SaveChangesAsync() > 0;

            return result;
        }

        public async Task<List<Course>> GetAll(GetAllRequest request)
        {
            int offset = request.PageIndex * request.PageSize;
            int take = request.PageSize;

            var result = await _dbContext.tbl_courses
                                .OrderBy(p => p.Id)
                                .Skip(offset)
                                .Take(take)
                                .ToListAsync();

            //"Select * from tablCourses OFFSET 10 LIMIT 10 ORDER BY ID ASC"

            return result;
        }

        public async Task<Course> GetById(GetByIdRequest request)
        {
            var result = await _dbContext.tbl_courses.FindAsync(request.Id);

            //"Select * from tablCourses OFFSET 10 LIMIT 10 ORDER BY ID ASC"

            return result;
        }

        public async Task<bool> Delete(int id)
        {
            var courseItem = await _dbContext.tbl_courses.FindAsync(id);

            _dbContext.tbl_courses.Remove(courseItem);
            bool result = await _dbContext.SaveChangesAsync() > 0;
            return result;
        }
    }
}
