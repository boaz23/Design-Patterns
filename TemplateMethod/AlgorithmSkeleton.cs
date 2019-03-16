using System;
using System.Collections.Generic;

namespace TemplateMethod {
    public abstract class AlgorithmSkeleton<T> {
        public bool Execute() {
            this.Step1();
            List<T> list = this.Step2();
            if (list == null) {
                return false;
            }

            IEnumerable<T> enumerable = this.Step3(list);
            foreach (T item in enumerable) {
                if (this.IsMatch(item)) {
                    this.ProccesItem(item);
                    return true;
                }
            }

            return false;
        }

        private void Step1() {
            Console.WriteLine("Step 1 performed.");
        }

        protected abstract List<T> Step2();
        protected abstract IEnumerable<T> Step3(List<T> list);

        protected abstract bool IsMatch(T item);
        protected virtual void ProccesItem(T item) {
            Console.WriteLine(item);
        }
    }
}