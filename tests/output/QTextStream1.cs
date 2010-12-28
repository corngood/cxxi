// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Wrappers {
    using System;
    using System.Runtime.InteropServices;
    using Mono.VisualC.Interop;
    
    public class QTextStream : ICppObject {
        protected CppInstancePtr native_ptr;
        private static IQTextStream impl = Wrappers.Libs.Lib.GetClass <IQTextStream, _QTextStream, QTextStream>("QTextStream");
        public QTextStream() {
            impl.QTextStream(this.Native);
        }
        public QTextStream(QIODevice device) {
            impl.QTextStream(this.Native, device);
        }
        public QTextStream(_IO_FILE fileHandle, QFlags<QIODevice::OpenModeFlag> openMode) {
            impl.QTextStream(this.Native, fileHandle, openMode);
        }
        public QTextStream(QString @string, QFlags<QIODevice::OpenModeFlag> openMode) {
            impl.QTextStream(this.Native, @string, openMode);
        }
        public QTextStream(QByteArray array, QFlags<QIODevice::OpenModeFlag> openMode) {
            impl.QTextStream(this.Native, array, openMode);
        }
        public QTextStream(QByteArray array, QFlags<QIODevice::OpenModeFlag> openMode) {
            impl.QTextStream(this.Native, array, openMode);
        }
        public CppInstancePtr Native {
            get {
                return this.native_ptr;
            }
        }
        public QTextCodec Codec {
            get {
                return impl.codec(this.Native);
            }
        }
        public bool AutoDetectUnicode {
            get {
                return impl.autoDetectUnicode(this.Native);
            }
            set {
                impl.setAutoDetectUnicode(this.Native, value);
            }
        }
        public bool GenerateByteOrderMark {
            get {
                return impl.generateByteOrderMark(this.Native);
            }
            set {
                impl.setGenerateByteOrderMark(this.Native, value);
            }
        }
        public QLocale Locale {
            get {
                return impl.locale(this.Native);
            }
            set {
                impl.setLocale(this.Native, value);
            }
        }
        public QIODevice Device {
            get {
                return impl.device(this.Native);
            }
            set {
                impl.setDevice(this.Native, value);
            }
        }
        public QString String {
            get {
                return impl.@string(this.Native);
            }
        }
        public Status Status {
            get {
                return impl.status(this.Native);
            }
            set {
                impl.setStatus(this.Native, value);
            }
        }
        public bool AtEnd {
            get {
                return impl.atEnd(this.Native);
            }
        }
        public long Pos {
            get {
                return impl.pos(this.Native);
            }
        }
        public FieldAlignment FieldAlignment {
            get {
                return impl.fieldAlignment(this.Native);
            }
            set {
                impl.setFieldAlignment(this.Native, value);
            }
        }
        public QChar PadChar {
            get {
                return impl.padChar(this.Native);
            }
            set {
                impl.setPadChar(this.Native, value);
            }
        }
        public int FieldWidth {
            get {
                return impl.fieldWidth(this.Native);
            }
            set {
                impl.setFieldWidth(this.Native, value);
            }
        }
        public QFlags<QTextStream::NumberFlag> NumberFlags {
            get {
                return impl.numberFlags(this.Native);
            }
            set {
                impl.setNumberFlags(this.Native, value);
            }
        }
        public int IntegerBase {
            get {
                return impl.integerBase(this.Native);
            }
            set {
                impl.setIntegerBase(this.Native, value);
            }
        }
        public RealNumberNotation RealNumberNotation {
            get {
                return impl.realNumberNotation(this.Native);
            }
            set {
                impl.setRealNumberNotation(this.Native, value);
            }
        }
        public int RealNumberPrecision {
            get {
                return impl.realNumberPrecision(this.Native);
            }
            set {
                impl.setRealNumberPrecision(this.Native, value);
            }
        }
        public virtual void Dispose() {
        }
        public void SetCodec(QTextCodec codec) {
            impl.setCodec(this.Native, codec);
        }
        public void SetCodec(string codecName) {
            impl.setCodec(this.Native, codecName);
        }
        public void SetString(QString @string, QFlags<QIODevice::OpenModeFlag> openMode) {
            impl.setString(this.Native, @string, openMode);
        }
        public void ResetStatus() {
            impl.resetStatus(this.Native);
        }
        public void Reset() {
            impl.reset(this.Native);
        }
        public void Flush() {
            impl.flush(this.Native);
        }
        public bool Seek(long pos) {
            return impl.seek(this.Native, pos);
        }
        public void SkipWhiteSpace() {
            impl.skipWhiteSpace(this.Native);
        }
        public QString ReadLine(long maxlen) {
            return impl.readLine(this.Native, maxlen);
        }
        public QString ReadAll() {
            return impl.readAll(this.Native);
        }
        public QString Read(long maxlen) {
            return impl.read(this.Native, maxlen);
        }
        public interface IQTextStream : ICppClassOverridable<QTextStream> {
            [Constructor()]
            void QTextStream(CppInstancePtr @this);
            [Constructor()]
            void QTextStream(CppInstancePtr @this, [MangleAs("class QIODevice *")] QIODevice device);
            [Constructor()]
            void QTextStream(CppInstancePtr @this, [MangleAs("struct _IO_FILE *")] _IO_FILE fileHandle, [MangleAs("class QFlags <QIODevice::OpenModeFlag>")] QFlags<QIODevice::OpenModeFlag> openMode);
            [Constructor()]
            void QTextStream(CppInstancePtr @this, [MangleAs("class QString *")] QString @string, [MangleAs("class QFlags <QIODevice::OpenModeFlag>")] QFlags<QIODevice::OpenModeFlag> openMode);
            [Constructor()]
            void QTextStream(CppInstancePtr @this, [MangleAs("class QByteArray *")] QByteArray array, [MangleAs("class QFlags <QIODevice::OpenModeFlag>")] QFlags<QIODevice::OpenModeFlag> openMode);
            [Constructor()]
            void QTextStream(CppInstancePtr @this, [MangleAs("class QByteArray const &")] QByteArray array, [MangleAs("class QFlags <QIODevice::OpenModeFlag>")] QFlags<QIODevice::OpenModeFlag> openMode);
            [Virtual()]
            [Destructor()]
            void Destruct(CppInstancePtr @this);
            void setCodec(CppInstancePtr @this, [MangleAs("class QTextCodec *")] QTextCodec codec);
            void setCodec(CppInstancePtr @this, [MangleAs("char const *")] string codecName);
            [Const()]
            QTextCodec codec(CppInstancePtr @this);
            [Const()]
            bool autoDetectUnicode(CppInstancePtr @this);
            void setAutoDetectUnicode(CppInstancePtr @this, [MangleAs("bool")] bool value);
            [Const()]
            bool generateByteOrderMark(CppInstancePtr @this);
            void setGenerateByteOrderMark(CppInstancePtr @this, [MangleAs("bool")] bool value);
            [Const()]
            QLocale locale(CppInstancePtr @this);
            void setLocale(CppInstancePtr @this, [MangleAs("class QLocale const &")] QLocale value);
            [Const()]
            QIODevice device(CppInstancePtr @this);
            void setDevice(CppInstancePtr @this, [MangleAs("class QIODevice *")] QIODevice value);
            void setString(CppInstancePtr @this, [MangleAs("class QString *")] QString @string, [MangleAs("class QFlags <QIODevice::OpenModeFlag>")] QFlags<QIODevice::OpenModeFlag> openMode);
            [Const()]
            QString @string(CppInstancePtr @this);
            [Const()]
            Status status(CppInstancePtr @this);
            void setStatus(CppInstancePtr @this, [MangleAs("enum Status")] Status value);
            void resetStatus(CppInstancePtr @this);
            [Const()]
            bool atEnd(CppInstancePtr @this);
            void reset(CppInstancePtr @this);
            void flush(CppInstancePtr @this);
            bool seek(CppInstancePtr @this, [MangleAs("int long long")] long pos);
            [Const()]
            long pos(CppInstancePtr @this);
            void skipWhiteSpace(CppInstancePtr @this);
            QString readLine(CppInstancePtr @this, [MangleAs("int long long")] long maxlen);
            QString readAll(CppInstancePtr @this);
            QString read(CppInstancePtr @this, [MangleAs("int long long")] long maxlen);
            [Const()]
            FieldAlignment fieldAlignment(CppInstancePtr @this);
            void setFieldAlignment(CppInstancePtr @this, [MangleAs("enum FieldAlignment")] FieldAlignment value);
            [Const()]
            QChar padChar(CppInstancePtr @this);
            void setPadChar(CppInstancePtr @this, [MangleAs("class QChar")] QChar value);
            [Const()]
            int fieldWidth(CppInstancePtr @this);
            void setFieldWidth(CppInstancePtr @this, [MangleAs("int")] int value);
            [Const()]
            QFlags<QTextStream::NumberFlag> numberFlags(CppInstancePtr @this);
            void setNumberFlags(CppInstancePtr @this, [MangleAs("class QFlags <QTextStream::NumberFlag>")] QFlags<QTextStream::NumberFlag> value);
            [Const()]
            int integerBase(CppInstancePtr @this);
            void setIntegerBase(CppInstancePtr @this, [MangleAs("int")] int value);
            [Const()]
            RealNumberNotation realNumberNotation(CppInstancePtr @this);
            void setRealNumberNotation(CppInstancePtr @this, [MangleAs("enum RealNumberNotation")] RealNumberNotation value);
            [Const()]
            int realNumberPrecision(CppInstancePtr @this);
            void setRealNumberPrecision(CppInstancePtr @this, [MangleAs("int")] int value);
        }
        private struct _QTextStream {
            // FIXME: Unknown type "class QScopedPointer <QTextStreamPrivate, QScopedPointerDeleter <QTextStreamPrivate>>" for field "d_ptr." Assuming IntPtr.
            private System.IntPtr d_ptr;
        }
    }
}