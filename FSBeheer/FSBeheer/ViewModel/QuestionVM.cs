﻿using FSBeheer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSBeheer.ViewModel
{
    public class QuestionVM
    {
        private Question _question;

        public QuestionVM(Question q)
        {
            _question = q;
        }

        public string Content
        {
            get { return _question.Content; }
        }

        public string Options
        {
            get { return _question.Options; }
        }

        public string Columns
        {
            get { return _question.Columns; }
        }

        public QuestionType Type
        {
            get { return _question.QuestionType; }
        }
    }
}
