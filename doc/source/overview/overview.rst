What is Aldsoft ACORD?
======================

This library helps read and write ACORD Standard compliant XML. Following the XML Schema
is simply not enough (validation against the .xsd), and the 1000+ page ACORD LA
documentation is proof of that. There are nuances and rules that need to be followed
when creating an ACORD compliant XML transmission, and these are buried in various
parts of the document. What I've done is try to capture these rules that cannot be
enforced in an XML Schema Definition, and instead I enforce them through a Fluent API.
I don't claim to have captured every rule, so please let me know if I'm missing some
and help improve this library.

What Aldsoft ACORD Can't Do
---------------------------

It cannot guarantee your output is ACORD Standards Compliant. You could use the library
and ignore the Fluent API (using just the ACORD Objects), then you might construct an
XML document which is valid against the XML Schema, but invalid against the ACORD Standard
business rules outlined within the official document. You will still need to be familiar
with the ACORD Standards, and this library is an excellent supplement to help build
legal ACORD Standards Compliant XML for transmission.