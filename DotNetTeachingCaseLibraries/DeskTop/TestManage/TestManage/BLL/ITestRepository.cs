﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestManage.DDL;

namespace TestManage.BLL
{
    public interface ITestRepository
    {
        /// <summary>
        /// 按科目查试卷
        /// </summary>
        /// <param name="subjectID">科目编号</param>
        /// <returns></returns>
        List<Test> GetTests(int subjectID);


        /// <summary>
        /// 添加试卷
        /// </summary>
        /// <param name="test">试卷</param>
        /// <returns></returns>
        bool AddTest(Test test);



        /// <summary>
        /// 修改试卷
        /// </summary>
        /// <param name="test">试卷</param>
        /// <returns></returns>
        bool ModifyTest(Test test);

        /// <summary>
        /// 删除试卷
        /// </summary>
        /// <param name="ID">试卷编号</param>
        /// <returns></returns>
        bool RemoveTest(int ID);

    }
}