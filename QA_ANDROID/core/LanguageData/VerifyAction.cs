using QA_ANDROID.core.Models;
using QA_ANDROID.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_ANDROID.core.LanguageData
{
    public class VerifyAction
    {
        public Logger log;
        private ClassTextReader _ctr;
        private List<Metric> _metrics;
        private List<MetricInfo> _MetricInfoList;

        public enum Verify
        {
            EXISTS,
            EQUAL,
            MORE_THAN,
            LESS_THAN,
            MORE_EQUAL,
            LESS_EQUAL
        }

        public VerifyAction(List<Metric> metricList)
        {
            _metrics = new List<Metric>();
            _metrics = metricList;
        }

        private void FindingCoincidencesWithFileNames(Metric metric, string baseApkPath)
        {
            List<string> FilePaths = new List<string>();
            List<string> dirPaths = new List<string>();

            foreach (string filedir in metric.SearchIn)
            {
                dirPaths = Directory.GetFiles(baseApkPath, filedir, SearchOption.AllDirectories).ToList();
                metric.SearchIn = dirPaths;
                foreach (string path in metric.SearchIn)
                { Console.WriteLine($"Archivo encontrado en: {path}"); }
            }
        }
                
        public List<MetricInfo> StartVerifications(string apkBasePath)
        {
            try
            {
                _MetricInfoList = new List<MetricInfo>();
                foreach (Metric metric in _metrics)
                {
                    FindingCoincidencesWithFileNames(metric, apkBasePath);
                    _MetricInfoList.Add(verify(metric));
                }
                return _MetricInfoList;

            }
            catch (Exception e)
            {
                log = new Logger();
                log.WriteInLog(e);
                return null;
            }
        }

        public MetricInfo verify(Metric metric)
        {
            try
            {
                Verify verify;
                Enum.TryParse(metric.Operation.ToUpper(), out verify);

                switch (verify)
                {
                    case Verify.EXISTS:
                        return VerifyExists(metric);

                    case Verify.EQUAL:
                        return VerifyEqual(metric);

                    case Verify.MORE_THAN:
                        return VerifyMoreThan(metric);

                    case Verify.LESS_THAN:
                        return VerifyLessThan(metric);

                    case Verify.MORE_EQUAL:
                        return VerifyMoreEqual(metric);

                    case Verify.LESS_EQUAL:
                        return VerifyLessEqual(metric);

                    default:
                        throw new Exception();
                }

            }
            catch (Exception e)
            {
                log = new Logger();
                log.WriteInLog(e);
                return null;
            }
        }
                
        private MetricInfo VerifyLessEqual(Metric metric)
        {
            try
            {
                bool resp = false;
                int localTimes = 0;
                MetricInfo mi;
                string files = string.Empty;

                foreach (string file_dir in metric.SearchIn)
                {
                    _ctr = new ClassTextReader(file_dir);
                    var classData = _ctr.READED_CLASS;
                    files += Path.GetFileName(file_dir) + " ";

                    foreach (var value in metric.Value)
                    {
                        localTimes = classData.Count(c => c.Equals(value));
                        resp = localTimes <= metric.Times;
                        if (resp != true)
                            break;
                    }
                }
                mi = new MetricInfo
                {
                    Name = metric.Name,
                    Description = metric.Description,
                    File = files,
                    Operation = metric.Operation.ToUpper(),
                    Result = resp
                };
                return mi;

            }
            catch (Exception e)
            {
                log = new Logger();
                log.WriteInLog(e);
                return null;
            }
        }

        private MetricInfo VerifyMoreEqual(Metric metric)
        {
            try
            {
                bool resp = false;
                int localTimes = 0;
                MetricInfo mi;
                string files = string.Empty;

                foreach (string file_dir in metric.SearchIn)
                {
                    _ctr = new ClassTextReader(file_dir);
                    var classData = _ctr.READED_CLASS;
                    files += Path.GetFileName(file_dir) + " ";

                    foreach (var value in metric.Value)
                    {
                        localTimes = classData.Count(c => c.Equals(value));
                        resp = localTimes >= metric.Times;
                        if (resp != true)
                            break;
                    }
                }
                mi = new MetricInfo
                {
                    Name = metric.Name,
                    Description = metric.Description,
                    File = files,
                    Operation = metric.Operation.ToUpper(),
                    Result = resp
                };
                return mi;

            }
            catch (Exception e)
            {
                log = new Logger();
                log.WriteInLog(e);
                return null;
            }
        }

        private MetricInfo VerifyLessThan(Metric metric)
        {
            try
            {
                bool resp = false;
                int localTimes = 0;
                MetricInfo mi;
                string files = string.Empty;

                foreach (string file_dir in metric.SearchIn)
                {
                    _ctr = new ClassTextReader(file_dir);
                    var classData = _ctr.READED_CLASS;
                    files += Path.GetFileName(file_dir) + " ";

                    foreach (var value in metric.Value)
                    {
                        localTimes = classData.Count(c => c.Equals(value));
                        resp = localTimes < metric.Times;
                        if (resp != true)
                            break;
                    }
                }
                mi = new MetricInfo
                {
                    Name = metric.Name,
                    Description = metric.Description,
                    File = files,
                    Operation = metric.Operation.ToUpper(),
                    Result = resp
                };
                return mi;

            }
            catch (Exception e)
            {
                log = new Logger();
                log.WriteInLog(e);
                return null;
            }
        }

        private MetricInfo VerifyMoreThan(Metric metric)
        {
            try
            {
                bool resp = false;
                int localTimes = 0;
                MetricInfo mi;
                string files = string.Empty;

                foreach (string file_dir in metric.SearchIn)
                {
                    _ctr = new ClassTextReader(file_dir);
                    var classData = _ctr.READED_CLASS;
                    files += Path.GetFileName(file_dir) + " ";

                    foreach (var value in metric.Value)
                    {
                        localTimes = classData.Count(c => c.Equals(value));
                        resp = localTimes > metric.Times;
                        if (resp != true)
                            break;
                    }
                }
                mi = new MetricInfo
                {
                    Name = metric.Name,
                    Description = metric.Description,
                    File = files,
                    Operation = metric.Operation.ToUpper(),
                    Result = resp
                };
                return mi;

            }
            catch (Exception e)
            {
                log = new Logger();
                log.WriteInLog(e);
                return null;
            }
        }

        private MetricInfo VerifyEqual(Metric metric)
        {
            try
            {
                bool resp = false;
                MetricInfo mi;
                string files = string.Empty;

                foreach (string file_dir in metric.SearchIn)
                {
                    _ctr = new ClassTextReader(file_dir);
                    var classData = _ctr.READED_CLASS;
                    files += Path.GetFileName(file_dir) + " ";

                    foreach (var value in metric.Value)
                    {
                        resp = classData.Count(c => c.Equals(value)) == metric.Times;
                        if (resp != true)
                            break;
                    }

                }
                mi = new MetricInfo
                {
                    Name = metric.Name,
                    Description = metric.Description,
                    File = files,
                    Operation = metric.Operation.ToUpper(),
                    Result = resp
                };


                return mi;

            }
            catch (Exception e)
            {
                log = new Logger();
                log.WriteInLog(e);
                return null;
            }
        }

        private MetricInfo VerifyExists(Metric metric)
        {

            try
            {
                bool resp = false;
                MetricInfo mi;
                string files = string.Empty;

                foreach (string file_dir in metric.SearchIn)
                {
                    _ctr = new ClassTextReader(file_dir);
                    var classData = _ctr.READED_CLASS;
                    files += Path.GetFileName(file_dir) + " ";

                    foreach (var value in metric.Value)
                    {
                        resp = classData.Contains(value);
                        if (resp != true)
                            break;
                    }
                }


                mi = new MetricInfo
                {
                    Name = metric.Name,
                    Description = metric.Description,
                    File = files,
                    Operation = metric.Operation.ToUpper(),
                    Result = resp
                };


                return mi;

            }
            catch (Exception e)
            {
                log = new Logger();
                log.WriteInLog(e);
                return null;

            }
        }
    }
}
