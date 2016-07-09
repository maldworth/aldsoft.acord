Using Aldsoft ACORD
===================

Everything in the ACORD standard, is build off the root element: **TXLife**, and
consists of Requests and Responses. There are some specific usage guidelines
for many of the major elements, and so the Fluent API should be used whenever
available, to help facilitate following these guidelines.

Fluent API
----------

There is a Fluent API available for the root element, and many of the major
elements directly beneath or a few tree levels below. This list will expand
with time and requests from the community.

+-----------------+
| ACORD Element   |
+=================+
| TXLife          |
+-----------------+
| UserAuthRequest |
+-----------------+
| OLifE           |
+-----------------+
| Life            |
+-----------------+
| Party           |
+-----------------+
| Policy          |
+-----------------+

All elements in the aldsoft.acord library have the identical name as defined
in the ACORD spec, but are appended with _Type.

*eg. TXLife_Type, Party_Type*

Fluent Builders
^^^^^^^^^^^^^^^

You can create a builder by using the static method .CreateBuilder() for types
that have Fluent Builders. The builder uses method chaining to help guide you
towards making an object that follows ACORD guidelines.

.. sourcecode:: csharp

    var builder = TXLife_Type.CreateBuilder();

.. note::
    You may notice in the intellisense, some methods are available on the builder
    but as you chain more and more, certain methods are gone, and new ones appear.
    This is intentional using a dynamic type of Fluent API.

Type Codes
----------

Type codes are used throughout the elements in ACORD and help provide context
to objects. There are so many type codes, it is impossible to know every one, so
you would often have to refer to the documentation.

Fortunately `IVC Software <(https://ivc.codeplex.com/>`_ had an xml with all the
typecodes (as of version 2.18). So I use T4 to generate the typecodes into Static
Classes for use. I didn't go through with a fine tune comb and add all the type
codes from the delta of 2.18 to 2.35, but I added some new ones that weren't there.
I imagine this will be filled in over time as people in the development community use it.

You can look at the xml file used to generate the classes with T4 `here <https://raw.githubusercontent.com/maldworth/aldsoft.acord/develop/src/Aldsoft.Acord.Core/SharedProject/LookupTypesPublic.xml>`_
and add to it then submit a pull request.