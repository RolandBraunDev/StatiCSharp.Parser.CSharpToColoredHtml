using System;
using System.Collections.Generic;
using System.Composition.Convention;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatiCSharp.Parser;

internal static class CustomCss
{
    public static string WithLineNumbers
    {
        get => """
                <style>
                .background {
                font-family: monaco, Consolas, LucidaConsole, monospace;
                background-color: #1e1e1e;
                overflow: auto;
                padding: 20px;
                font-size: 0.8em;
                }
                pre .numeric {
                  color: #b5cea8;
                }
                pre .method {
                  color: #dcdcaa;
                }
                pre .class {
                  color: #4ec9b0;
                }
                pre .keyword {
                  color: #569cd6;
                }
                pre .string {
                  color: #ce9178;
                }
                pre .interface {
                  color: #b8d7a3;
                }
                pre .enumName {
                  color: #b8d7a3;
                }
                pre .numericLiteral {
                  color: #b8d7a3;
                }
                pre .recordStruct {
                  color: #b8d7a3;
                }
                pre .typeParam {
                  color: #b8d7a3;
                }
                pre .extension {
                  color: #b8d7a3;
                }
                pre .control {
                  color: #c586c0;
                }
                pre .internalError {
                  color: #ff0d0d;
                }
                pre .comment {
                  color: #6a9955;
                }
                pre .preprocessor {
                  color: #808080;
                }
                pre .preprocessorText {
                  color: #a4a4a4;
                }
                pre .struct {
                  color: #86c691;
                }
                pre .namespace {
                  color: #dfdfdf;
                }
                pre .enumMember {
                  color: #dfdfdf;
                }
                pre .identifier {
                  color: #dfdfdf;
                }
                pre .punctuation {
                  color: #dfdfdf;
                }
                pre .operator {
                  color: #dfdfdf;
                }
                pre .propertyName {
                  color: #dfdfdf;
                }
                pre .fieldName {
                  color: #dfdfdf;
                }
                pre .labelName {
                  color: #dfdfdf;
                }
                pre .operator_overloaded {
                  color: #dfdfdf;
                }
                pre .constant {
                  color: #dfdfdf;
                }
                pre .localName {
                  color: #9cdcfe;
                }
                pre .parameter {
                  color: #9cdcfe;
                }
                pre .delegate {
                  color: #4ec9b0;
                }
                pre .eventName {
                  color: #dfdfdf;
                }
                pre .excludedCode {
                  color: #808080;
                }
                pre table {
                  white-space: pre;
                }
                pre .line_no::before {
                  content: attr(line_no);
                  color: white;
                }
                pre .code_column {
                  padding-left: 5px;
                }
                pre {
                  color: #dbebeb;
                }
                </style>
                """;
    }

    public static string WithoutLineNumbers
    {
        get => """
                <style>
                .background {
                font-family: monaco, Consolas, LucidaConsole, monospace;
                background-color: #1e1e1e;
                overflow: auto;
                padding: 20px;
                font-size: 0.8em;
                }
                pre .numeric {
                  color: #b5cea8;
                }
                pre .method {
                  color: #dcdcaa;
                }
                pre .class {
                  color: #4ec9b0;
                }
                pre .keyword {
                  color: #569cd6;
                }
                pre .string {
                  color: #ce9178;
                }
                pre .interface {
                  color: #b8d7a3;
                }
                pre .enumName {
                  color: #b8d7a3;
                }
                pre .numericLiteral {
                  color: #b8d7a3;
                }
                pre .recordStruct {
                  color: #b8d7a3;
                }
                pre .typeParam {
                  color: #b8d7a3;
                }
                pre .extension {
                  color: #b8d7a3;
                }
                pre .control {
                  color: #c586c0;
                }
                pre .internalError {
                  color: #ff0d0d;
                }
                pre .comment {
                  color: #6a9955;
                }
                pre .preprocessor {
                  color: #808080;
                }
                pre .preprocessorText {
                  color: #a4a4a4;
                }
                pre .struct {
                  color: #86c691;
                }
                pre .namespace {
                  color: #dfdfdf;
                }
                pre .enumMember {
                  color: #dfdfdf;
                }
                pre .identifier {
                  color: #dfdfdf;
                }
                .punctuation {
                  color: #dfdfdf;
                }
                pre .operator {
                  color: #dfdfdf;
                }
                pre .propertyName {
                  color: #dfdfdf;
                }
                pre .fieldName {
                  color: #dfdfdf;
                }
                pre .labelName {
                  color: #dfdfdf;
                }
                pre .operator_overloaded {
                  color: #dfdfdf;
                }
                pre .constant {
                  color: #dfdfdf;
                }
                pre .localName {
                  color: #9cdcfe;
                }
                pre .parameter {
                  color: #9cdcfe;
                }
                pre .delegate {
                  color: #4ec9b0;
                }
                pre .eventName {
                  color: #dfdfdf;
                }
                pre .excludedCode {
                  color: #808080;
                }
                pre {
                  color: #dbebeb;
                }
                </style>
                """;
    }
}
