﻿using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryPack.Generator;

internal static class DiagnosticDescriptors
{
    const string Category = "GenerateMemoryPack";

    public static readonly DiagnosticDescriptor MustBePartial = new(
        id: "MEMPACK001",
        title: "MemoryPackable object must be partial",
        messageFormat: "The MemoryPackable object '{0}' must be partial",
        category: Category,
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    public static readonly DiagnosticDescriptor NestedNotAllow = new(
        id: "MEMPACK002",
        title: "MemoryPackable object must not be nested type",
        messageFormat: "The MemoryPackable object '{0}' must be not nested type",
        category: Category,
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    public static readonly DiagnosticDescriptor AbstractMustUnion = new(
        id: "MEMPACK003",
        title: "abstract/interface type of MemoryPackable object must annotate with Union",
        messageFormat: "abstract/interface type of MemoryPackable object '{0}' must annotate with Union",
        category: Category,
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    public static readonly DiagnosticDescriptor MultipleCtorWithoutAttribute = new(
        id: "MEMPACK004",
        title: "Require [MemoryPackConstructor] when exists multiple constructors",
        messageFormat: "The MemoryPackable object '{0}' must annotate with [MemoryPackConstructor] when exists multiple constructors",
        category: Category,
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    public static readonly DiagnosticDescriptor MultipleCtorAttribute = new(
        id: "MEMPACK005",
        title: "[MemoryPackConstructor] exists in multiple constructors",
        messageFormat: "Mupltiple [MemoryPackConstructor] exists in '{0}' but allows only single ctor",
        category: Category,
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    public static readonly DiagnosticDescriptor ConstructorHasNoMatchedParameter = new(
        id: "MEMPACK006",
        title: "MemoryPackObject's constructor has no matched parameter",
        messageFormat: "The MemoryPackable object '{0}' constructor's all parameters must match serialized member name(case-insensitive)",
        category: Category,
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    public static readonly DiagnosticDescriptor OnMethodHasParameter = new(
        id: "MEMPACK007",
        title: "MemoryPackObject's On*** methods must has no parameter",
        messageFormat: "The MemoryPackable object '{0}''s '{1}' method must has no parameter",
        category: Category,
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    public static readonly DiagnosticDescriptor OnMethodInUnamannagedType = new(
        id: "MEMPACK008",
        title: "MemoryPackObject's On*** methods can't annotate in unamnaged struct",
        messageFormat: "The MemoryPackable object '{0}' is unmanaged struct that can't annotate On***Attribute however '{1}' method annotaed",
        category: Category,
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    public static readonly DiagnosticDescriptor OverrideMemberCantAddAnnotation = new(
        id: "MEMPACK009",
        title: "Override member can't annotate Ignore/Include attribute",
        messageFormat: "The MemoryPackable object '{0}' override member '{1}' can't annotate {2} attribute",
        category: Category,
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    public static readonly DiagnosticDescriptor SealedTypeCantBeUnion = new(
        id: "MEMPACK010",
        title: "Sealed type can't be union",
        messageFormat: "The MemoryPackable object '{0}' is sealed type so can't be Union",
        category: Category,
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true);


    public static readonly DiagnosticDescriptor ConcreteTypeCantBeUnion = new(
        id: "MEMPACK011",
        title: "Concrete type can't be union",
        messageFormat: "The MemoryPackable object '{0}' can be Union, only allow abstract or interface",
        category: Category,
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true);


    public static readonly DiagnosticDescriptor UnionTagDuplicate = new(
        id: "MEMPACK012",
        title: "Union tag is duplicate",
        messageFormat: "The MemoryPackable object '{0}' union tag value is duplicate",
        category: Category,
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true);


    public static readonly DiagnosticDescriptor UnionMemberTypeNotImplementBaseType = new(
        id: "MEMPACK013",
        title: "Union member not implement union interface",
        messageFormat: "The MemoryPackable object '{0}' union member '{1}' not implment union interface",
        category: Category,
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true);


    public static readonly DiagnosticDescriptor UnionMemberTypeNotDerivedBaseType = new(
        id: "MEMPACK014",
        title: "Union member not dervided union base type",
        messageFormat: "The MemoryPackable object '{0}' union member '{1}' not derived union type",
        category: Category,
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    public static readonly DiagnosticDescriptor UnionMemberNotAllowStruct = new(
        id: "MEMPACK015",
        title: "Union member can't be struct",
        messageFormat: "The MemoryPackable object '{0}' union member '{1}' can't be member, not allows struct",
        category: Category,
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    public static readonly DiagnosticDescriptor UnionMemberMustBeMemoryPackable = new(
        id: "MEMPACK016",
        title: "Union member must be MemoryPackable",
        messageFormat: "The MemoryPackable object '{0}' union member '{1}' must be MemoryPackable",
        category: Category,
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    public static readonly DiagnosticDescriptor MembersCountOver250 = new(
        id: "MEMPACK017",
        title: "Members count limit",
        messageFormat: "The MemoryPackable object '{0}' member count is '{1}', however limit size is 249",
        category: Category,
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    public static readonly DiagnosticDescriptor MemberCantSerializeType = new(
        id: "MEMPACK018",
        title: "Member can't serialize type",
        messageFormat: "The MemoryPackable object '{0}' member '{1}' type is '{2}' that can't serialize",
        category: Category,
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    public static readonly DiagnosticDescriptor MemberIsNotMemoryPackable = new(
        id: "MEMPACK019",
        title: "Member is not MemoryPackable object",
        messageFormat: "The MemoryPackable object '{0}' member '{1}' type '{2}' is not MemoryPackable. Annotate [MemoryPackable] to '{2}' or if external type that can serialize, annotate `[MemoryPackAllowSerialize]` to member",
        category: Category,
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    public static readonly DiagnosticDescriptor TypeIsRefStruct = new(
        id: "MEMPACK020",
        title: "Type is ref struct",
        messageFormat: "The MemoryPackable object '{0}' is ref struct, it can not serialize",
        category: Category,
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    public static readonly DiagnosticDescriptor MemberIsRefStruct = new(
        id: "MEMPACK021",
        title: "Member is ref struct",
        messageFormat: "The MemoryPackable object '{0}' member '{1}' type '{2}' is ref struct, it can not serialize",
        category: Category,
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    public static readonly DiagnosticDescriptor CollectionGenerateIsAbstract = new(
        id: "MEMPACK022",
        title: "Collection type not allows interface/abstract",
        messageFormat: "The MemoryPackable object '{0}' is GenerateType.Collection but interface/abstract, only allows concrete type",
        category: Category,
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    public static readonly DiagnosticDescriptor CollectionGenerateNotImplementedInterface = new(
        id: "MEMPACK023",
        title: "Collection type must implement collection interface",
        messageFormat: "The MemoryPackable object '{0}' is GenerateType.Collection but not implemented collection interface(ICollection<T>/ISet<T>/IDictionary<TKey,TValue>)",
        category: Category,
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    public static readonly DiagnosticDescriptor CollectionGenerateNoParameterlessConstructor = new(
        id: "MEMPACK024",
        title: "Collection type must require parameterless constructor",
        messageFormat: "The MemoryPackable object '{0}' is GenerateType.Collection but not exists parameterless constructor",
        category: Category,
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    public static readonly DiagnosticDescriptor AllMembersMustAnnotateOrder = new(
        id: "MEMPACK025",
        title: "All members must annotate MemoryPackOrder when SerializeLayout.Explicit",
        messageFormat: "The MemoryPackable object '{0}' member '{1}' is not annotated MemoryPackOrder",
        category: Category,
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    public static readonly DiagnosticDescriptor AllMembersMustBeContinuousNumber = new(
        id: "MEMPACK026",
        title: "All MemoryPackOrder members must be continuous number from zero",
        messageFormat: "The MemoryPackable object '{0}' member '{1}' is not continuous number from zero",
        category: Category,
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true);
}
