using System;
using System.Threading.Tasks;

namespace ClouDeveloper.Delegates
{
    public static class ActionTaskExtensions
    {
        public static async Task
            ToTask(

            this Action @this,
            AsyncCallback asyncCallback = null,
            object state = null,
            TaskCreationOptions taskCreationOptions = default(TaskCreationOptions),
            TaskScheduler taskScheduler = null)
        {
            await Task.Factory.FromAsync(
                @this.BeginInvoke(asyncCallback, state),
                @this.EndInvoke,
                taskCreationOptions,
                taskScheduler ?? TaskScheduler.Current ?? TaskScheduler.Default)
                .ConfigureAwait(false);
        }

        public static async Task
            ToTask<T>(

            this Action<T> @this,
            T obj,
            AsyncCallback asyncCallback = null,
            object state = null,
            TaskCreationOptions taskCreationOptions = default(TaskCreationOptions),
            TaskScheduler taskScheduler = null)
        {
            await Task.Factory.FromAsync(
                @this.BeginInvoke(obj, asyncCallback, state),
                @this.EndInvoke,
                taskCreationOptions,
                taskScheduler ?? TaskScheduler.Current ?? TaskScheduler.Default)
                .ConfigureAwait(false);
        }

        public static async Task
            ToTask<T1, T2>(

            this Action<T1, T2> @this,
            T1 arg1, T2 arg2,
            AsyncCallback asyncCallback = null,
            object state = null,
            TaskCreationOptions taskCreationOptions = default(TaskCreationOptions),
            TaskScheduler taskScheduler = null)
        {
            await Task.Factory.FromAsync(
                @this.BeginInvoke(arg1, arg2, asyncCallback, state),
                @this.EndInvoke,
                taskCreationOptions,
                taskScheduler ?? TaskScheduler.Current ?? TaskScheduler.Default)
                .ConfigureAwait(false);
        }

        public static async Task
            ToTask<T1, T2, T3>(

            this Action<T1, T2, T3> @this,
            T1 arg1, T2 arg2, T3 arg3,
            AsyncCallback asyncCallback = null,
            object state = null,
            TaskCreationOptions taskCreationOptions = default(TaskCreationOptions),
            TaskScheduler taskScheduler = null)
        {
            await Task.Factory.FromAsync(
                @this.BeginInvoke(arg1, arg2, arg3, asyncCallback, state),
                @this.EndInvoke,
                taskCreationOptions,
                taskScheduler ?? TaskScheduler.Current ?? TaskScheduler.Default)
                .ConfigureAwait(false);
        }

        public static async Task
            ToTask<T1, T2, T3, T4>(

            this Action<T1, T2, T3, T4> @this,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            AsyncCallback asyncCallback = null,
            object state = null,
            TaskCreationOptions taskCreationOptions = default(TaskCreationOptions),
            TaskScheduler taskScheduler = null)
        {
            await Task.Factory.FromAsync(
                @this.BeginInvoke(arg1, arg2, arg3, arg4, asyncCallback, state),
                @this.EndInvoke,
                taskCreationOptions,
                taskScheduler ?? TaskScheduler.Current ?? TaskScheduler.Default)
                .ConfigureAwait(false);
        }

        public static async Task
            ToTask<T1, T2, T3, T4, T5>(

            this Action<T1, T2, T3, T4, T5> @this,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
            AsyncCallback asyncCallback = null,
            object state = null,
            TaskCreationOptions taskCreationOptions = default(TaskCreationOptions),
            TaskScheduler taskScheduler = null)
        {
            await Task.Factory.FromAsync(
                @this.BeginInvoke(arg1, arg2, arg3, arg4, arg5, asyncCallback, state),
                @this.EndInvoke,
                taskCreationOptions,
                taskScheduler ?? TaskScheduler.Current ?? TaskScheduler.Default)
                .ConfigureAwait(false);
        }

        public static async Task
            ToTask<T1, T2, T3, T4, T5, T6>(

            this Action<T1, T2, T3, T4, T5, T6> @this,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6,
            AsyncCallback asyncCallback = null,
            object state = null,
            TaskCreationOptions taskCreationOptions = default(TaskCreationOptions),
            TaskScheduler taskScheduler = null)
        {
            await Task.Factory.FromAsync(
                @this.BeginInvoke(arg1, arg2, arg3, arg4, arg5, arg6, asyncCallback, state),
                @this.EndInvoke,
                taskCreationOptions,
                taskScheduler ?? TaskScheduler.Current ?? TaskScheduler.Default)
                .ConfigureAwait(false);
        }

        public static async Task
            ToTask<T1, T2, T3, T4, T5, T6, T7>(

            this Action<T1, T2, T3, T4, T5, T6, T7> @this,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
            AsyncCallback asyncCallback = null,
            object state = null,
            TaskCreationOptions taskCreationOptions = default(TaskCreationOptions),
            TaskScheduler taskScheduler = null)
        {
            await Task.Factory.FromAsync(
                @this.BeginInvoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, asyncCallback, state),
                @this.EndInvoke,
                taskCreationOptions,
                taskScheduler ?? TaskScheduler.Current ?? TaskScheduler.Default)
                .ConfigureAwait(false);
        }

        public static async Task
            ToTask<T1, T2, T3, T4, T5, T6, T7, T8>(

            this Action<T1, T2, T3, T4, T5, T6, T7, T8> @this,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8,
            AsyncCallback asyncCallback = null,
            object state = null,
            TaskCreationOptions taskCreationOptions = default(TaskCreationOptions),
            TaskScheduler taskScheduler = null)
        {
            await Task.Factory.FromAsync(
                @this.BeginInvoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, asyncCallback, state),
                @this.EndInvoke,
                taskCreationOptions,
                taskScheduler ?? TaskScheduler.Current ?? TaskScheduler.Default)
                .ConfigureAwait(false);
        }

        public static async Task
            ToTask<T1, T2, T3, T4, T5, T6, T7, T8, T9>(

            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> @this,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
            AsyncCallback asyncCallback = null,
            object state = null,
            TaskCreationOptions taskCreationOptions = default(TaskCreationOptions),
            TaskScheduler taskScheduler = null)
        {
            await Task.Factory.FromAsync(
                @this.BeginInvoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, asyncCallback, state),
                @this.EndInvoke,
                taskCreationOptions,
                taskScheduler ?? TaskScheduler.Current ?? TaskScheduler.Default)
                .ConfigureAwait(false);
        }

        public static async Task
            ToTask<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(

            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> @this,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10,
            AsyncCallback asyncCallback = null,
            object state = null,
            TaskCreationOptions taskCreationOptions = default(TaskCreationOptions),
            TaskScheduler taskScheduler = null)
        {
            await Task.Factory.FromAsync(
                @this.BeginInvoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, asyncCallback, state),
                @this.EndInvoke,
                taskCreationOptions,
                taskScheduler ?? TaskScheduler.Current ?? TaskScheduler.Default)
                .ConfigureAwait(false);
        }

        public static async Task
            ToTask<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(

            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> @this,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11,
            AsyncCallback asyncCallback = null,
            object state = null,
            TaskCreationOptions taskCreationOptions = default(TaskCreationOptions),
            TaskScheduler taskScheduler = null)
        {
            await Task.Factory.FromAsync(
                @this.BeginInvoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, asyncCallback, state),
                @this.EndInvoke,
                taskCreationOptions,
                taskScheduler ?? TaskScheduler.Current ?? TaskScheduler.Default)
                .ConfigureAwait(false);
        }

        public static async Task
            ToTask<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(

            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> @this,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12,
            AsyncCallback asyncCallback = null,
            object state = null,
            TaskCreationOptions taskCreationOptions = default(TaskCreationOptions),
            TaskScheduler taskScheduler = null)
        {
            await Task.Factory.FromAsync(
                @this.BeginInvoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, asyncCallback, state),
                @this.EndInvoke,
                taskCreationOptions,
                taskScheduler ?? TaskScheduler.Current ?? TaskScheduler.Default)
                .ConfigureAwait(false);
        }

        public static async Task
            ToTask<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(

            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> @this,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13,
            AsyncCallback asyncCallback = null,
            object state = null,
            TaskCreationOptions taskCreationOptions = default(TaskCreationOptions),
            TaskScheduler taskScheduler = null)
        {
            await Task.Factory.FromAsync(
                @this.BeginInvoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, asyncCallback, state),
                @this.EndInvoke,
                taskCreationOptions,
                taskScheduler ?? TaskScheduler.Current ?? TaskScheduler.Default)
                .ConfigureAwait(false);
        }

        public static async Task
            ToTask<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(

            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> @this,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14,
            AsyncCallback asyncCallback = null,
            object state = null,
            TaskCreationOptions taskCreationOptions = default(TaskCreationOptions),
            TaskScheduler taskScheduler = null)
        {
            await Task.Factory.FromAsync(
                @this.BeginInvoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, asyncCallback, state),
                @this.EndInvoke,
                taskCreationOptions,
                taskScheduler ?? TaskScheduler.Current ?? TaskScheduler.Default)
                .ConfigureAwait(false);
        }

        public static async Task
            ToTask<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(

            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> @this,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15,
            AsyncCallback asyncCallback = null,
            object state = null,
            TaskCreationOptions taskCreationOptions = default(TaskCreationOptions),
            TaskScheduler taskScheduler = null)
        {
            await Task.Factory.FromAsync(
                @this.BeginInvoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, asyncCallback, state),
                @this.EndInvoke,
                taskCreationOptions,
                taskScheduler ?? TaskScheduler.Current ?? TaskScheduler.Default)
                .ConfigureAwait(false);
        }

        public static async Task
            ToTask<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(

            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> @this,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16,
            AsyncCallback asyncCallback = null,
            object state = null,
            TaskCreationOptions taskCreationOptions = default(TaskCreationOptions),
            TaskScheduler taskScheduler = null)
        {
            await Task.Factory.FromAsync(
                @this.BeginInvoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, asyncCallback, state),
                @this.EndInvoke,
                taskCreationOptions,
                taskScheduler ?? TaskScheduler.Current ?? TaskScheduler.Default)
                .ConfigureAwait(false);
        }
    }
}
