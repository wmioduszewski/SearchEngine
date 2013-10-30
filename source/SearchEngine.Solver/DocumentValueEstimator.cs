﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SearchEngine.Solver.Model;

namespace SearchEngine.Solver
{
    public class DocumentValueEstimator
    {
        static void CompareDocumentToQuery(Document document, Query query)
        {
            double res = 0;
            var queryFreq = query.IdfResult;
            foreach (var idfRes in document.IdfResult)
            {
                if (queryFreq.ContainsKey(idfRes.Key))
                    res += idfRes.Value * queryFreq[idfRes.Key];
            }

            var denominator = query.VectorLength * document.VectorLength;
            if (denominator == 0) res = 0;
            else res /= denominator;
            document.Similarity = res;
        }

        public static void CompareDocumentsToQuery(List<Document> documents, Query query)
        {
            foreach (var doc in documents)
            {
                CompareDocumentToQuery(doc,query);
            }
        }

        
    }
}
