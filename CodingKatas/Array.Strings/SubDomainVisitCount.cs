using System.Collections.Generic;
using System.Linq;

namespace CodingKatas.Array.Strings
{
    public class SubDomainVisitCount
    {
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            var dict = new Dictionary<string, int>();
            foreach (var word in cpdomains)
            {
                var cpDomain = word.Split(' ');
                var visits = int.Parse(cpDomain[0]);
                var domain = cpDomain[1];
                var idx = domain.Trim().IndexOf('.');
                
                while (idx >= 0)
                {
                    idx = domain.IndexOf('.');
                    if (dict.ContainsKey(domain))
                    {
                        dict[domain] += visits;
                    }
                    else
                    {
                        dict.Add(domain, visits);
                    }

                    domain = domain.Substring(idx + 1);
                }
            }
            return dict.Select((item) => $"{item.Value} {item.Key}").ToList();
        }    
    }
    
    
}