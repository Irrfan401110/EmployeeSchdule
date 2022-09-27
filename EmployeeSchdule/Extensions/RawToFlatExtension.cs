using EmployeeSchdule.Dto;
using EmployeeSchdule.Helper;
using EmployeeSchdule.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeSchdule.Extentions
{
    public static class RawToFlatExtension
    {
        static ListKeyValue _rawToFlatList = new ListKeyValue();
        public static ListKeyValue RawToFlat(this Employee employee)
        {
            _rawToFlatList.Clear();
            DividedShiftBreak(employee.Shifts.FirstOrDefault(), employee.Breaks.ToList(), employee.Leaves.FirstOrDefault());
            return _rawToFlatList;
        }

        private static void DividedShiftBreak(Shift shift, List<Break> brks, Leave leave)
        {
            if (shift.StartTime == shift.EndTime) return;
            if (brks.Count() > 0)
            {
                Break brk = brks.FirstOrDefault();
                if (brk.StartTime >= shift.StartTime
                    && brk.StartTime <= shift.EndTime)
                {
                    _rawToFlatList.Add("Shift", MapTo(shift.StartTime, brk.StartTime));
                    _rawToFlatList.Add("Break", MapTo(brk.StartTime, brk.EndTime));
                    shift.StartTime = brk.EndTime;
                    brks.Remove(brk);
                    DividedShiftBreak(shift, brks, leave);
                }
            }
            else
            {
                DividedShiftLeave(shift, leave);
            }
        }
        private static void DividedShiftLeave(Shift shift, Leave leave)
        {
            if (leave == null) _rawToFlatList.Add("Shift", MapTo(shift.StartTime, shift.EndTime));
            else if (leave.StartTime >= shift.StartTime
                        && leave.StartTime <= shift.EndTime)
            {
                _rawToFlatList.Add("Leave", MapTo(leave.StartTime, shift.EndTime));
            }
            else if (leave.StartTime <= shift.StartTime)
            {
                _rawToFlatList.Add("Leave", MapTo(shift.StartTime, shift.EndTime));
            }
            else
            {
                _rawToFlatList.Add("Shift", MapTo(shift.StartTime, shift.EndTime));
            }
        }

        private static ResponseDto MapTo(TimeSpan? startTime, TimeSpan? endTime)
        {
            return new ResponseDto()
            {
                StartTime = startTime,
                EndTime = endTime,
            };
        }
    }

}